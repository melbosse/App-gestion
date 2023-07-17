' Bibliothèque du Framework nécéssaire pour SQL SERVER
Imports System.Data.SqlClient
Imports TP1_Melina_Sofia.My

Public Enum Action
    Aucune = 0
    Ajout = 1
    Modif = 2
End Enum

Public Class FrmProgramme
    ' Variables globales du formulaire
    Dim CnTp1 As SqlConnection
    Dim ComProg As SqlCommand
    Dim Dr As SqlDataReader
    Dim act As Action = Action.Aucune
    Private Sub FrmProgramme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '1) Configurer la connexion à la base de données BD tp_p44
            CnTp1 = New SqlConnection(My.Settings.CnTp1)
            CnTp1.Open()
            '2) Configurer la ComProg pour récuperer tous les programmes
            ComProg = New SqlCommand("select * from T_programme", CnTp1)
            '3) Remplir le ListView des Programmes
            Remplir_ListView_Programme()
            If LvProgramme.Items.Count > 0 Then
                LvProgramme.Focus()
                LvProgramme.SelectedIndices.Add(0)
                CmdModifier.Enabled = True
            End If
        Catch ex As SqlException
            MsgBox(ex.Number & "" & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Remplir_ListView_Programme()
        '1) Vider le ListView des programmes 
        LvProgramme.Items.Clear()
        '2) Créer le DataReader
        Dr = ComProg.ExecuteReader()
        '3) Lire le contenu du DataReader et l'ajouter à la listeView des programmes
        Dim Ligne As ListViewItem
        Do While Dr.Read()
            Ligne = New ListViewItem(Dr.Item("pro_no").ToString())
            Ligne.SubItems.Add(Dr("pro_nom").ToString())
            Ligne.SubItems.Add(Dr("pro_nbr_unites").ToString())
            Ligne.SubItems.Add(Dr("pro_nbr_heures").ToString())
            Ligne.Tag = Dr("pro_no").ToString()
            LvProgramme.Items.Add(Ligne)
        Loop
        '4) Fermer le DataReader
        Dr.Close()

    End Sub

    Private Sub LvProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvProgramme.SelectedIndexChanged
        If LvProgramme.SelectedItems.Count > 0 Then
            Recuperer_Programme(LvProgramme.SelectedItems(0).Tag)
            Recuperer_Etudiant_Programme(LvProgramme.SelectedItems(0).Tag)

        End If
    End Sub

    Private Sub Recuperer_Etudiant_Programme(NoProgramme As String)
        Try
            '1) Configuration d'une commande pour récuperer les étudiants par programme
            Dim ComRechEtuProg As New SqlCommand _
                ("select e.etu_da ,p.pro_no ,e.etu_prenom , e.etu_nom from T_etudiants e " _
                & "inner join T_programme p on e.pro_no = p.pro_no where p.pro_no= @prog", CnTp1)
            ComRechEtuProg.Parameters.AddWithValue("@prog", NoProgramme)
            '2) Créer le DataReader
            Dr = ComRechEtuProg.ExecuteReader()
            '3) Remplir le ListView des Etudiants par Programme
            Remplir_ListView_Etudiant_Par_Programme()
            CmdEnlever.Enabled = Not LvEtuProg.Items.Count > 0
        Catch ex As SqlException
            MsgBox(ex.Number & "" & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Remplir_ListView_Etudiant_Par_Programme()
        '1) Vider la ListView
        LvEtuProg.Items.Clear()
        '2) Lire le contenu du DataReader et l'ajouter à la listeView
        Dim Ligne As ListViewItem
        Do While Dr.Read()
            Ligne = New ListViewItem(Dr.Item("etu_da").ToString())
            Ligne.SubItems.Add(Dr("pro_no").ToString())
            Ligne.SubItems.Add(Dr("etu_prenom").ToString())
            Ligne.SubItems.Add(Dr("etu_nom").ToString())

            LvEtuProg.Items.Add(Ligne)
        Loop
        '3) Fermer le DataReader
        Dr.Close()

    End Sub

    Private Sub Recuperer_Programme(NoProgramme As String)
        Try
            '1) Configurer une commande pour récuperer un programme en particulier
            Dim ComRechProg As New SqlCommand("select * from T_programme where pro_no=@prog", CnTp1)
            '2) Créer et assigner une valeur au paramètres
            ComRechProg.Parameters.AddWithValue("@prog", NoProgramme)
            '3) Créer le DataReader
            Dr = ComRechProg.ExecuteReader()
            '4) Lire le DataReader
            If Dr.Read() Then
                ' Assigner les valeurs au formulaire
                MskNo.Text = Dr("pro_no").ToString()
                TxtNom.Text = Dr("pro_nom").ToString()
                TxtUnites.Text = Dr("pro_nbr_unites").ToString()
                TxtHeures.Text = Dr("pro_nbr_heures").ToString()
            End If
            '5) Fermer le DataReader
            Dr.Close()
        Catch ex As SqlException
            MsgBox(ex.Number & "" & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmdNouveau_Click(sender As Object, e As EventArgs) Handles CmdNouveau.Click
        '1) Barrer des contrôles
        Barrer(CmdNouveau, CmdModifier, CmdEnlever, LvProgramme, LvEtuProg)
        '2) Débarrer des contrôles
        Debarrer(CmdOk, CmdAnnuler, GrpProgramme)
        '3) Vider le formulaire
        Vider_Formulaire()
        '4) Se positionner sur le premier champ à remplir
        MskNo.Focus()
        act = Action.Ajout
    End Sub

    Private Sub Vider_Formulaire()
        MskNo.Clear()
        TxtNom.Clear()
        TxtUnites.Clear()
        TxtHeures.Clear()
        LvEtuProg.Items.Clear()
    End Sub
    Private Sub Barrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = False
        Next
    End Sub

    Private Sub Debarrer(ParamArray ctrl() As Control)
        For Each c As Control In ctrl
            c.Enabled = True
        Next
    End Sub

    Private Sub CmdEnlever_Click(sender As Object, e As EventArgs) Handles CmdEnlever.Click
        '1) Demander une confirmation de suppression du programme
        Dim rep As DialogResult
        rep = MessageBox.Show("Voulez-vous supprimer ce programme?", "Confirmation",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Enlever_Programme()
        End If
    End Sub

    Private Sub Enlever_Programme()
        Try
            '1) Création de la commande pour faire la suppression
            Dim ComEnlever As New SqlCommand()

            With ComEnlever
                .CommandText = "Enlever_Programme"
                .CommandType = CommandType.StoredProcedure
                .Connection = CnTp1
                .Parameters.AddWithValue("@no", MskNo.Text)
            End With
            '2) Exécuter la commande
            If ComEnlever.ExecuteNonQuery() > 0 Then
                MsgBox("Le programme a été enlevé avec succès...")
            End If
            Remplir_ListView_Programme()
            If LvProgramme.Items.Count > 0 Then
                LvProgramme.SelectedIndices.Add(0)
            Else
                Vider_Formulaire()
                CmdModifier.Enabled = False
                CmdEnlever.Enabled = False
            End If
        Catch ex As SqlException
            MsgBox(ex.Number & "" & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmdModifier_Click(sender As Object, e As EventArgs) Handles CmdModifier.Click
        '1) Barrer des contrôles
        Barrer(CmdNouveau, CmdModifier, CmdEnlever, LvProgramme, LvEtuProg)
        '2) Débarrer des contrôles
        Debarrer(CmdOk, CmdAnnuler, GrpProgramme)

        '3) Se positionner sur le premier champ à remplir
        MskNo.Focus()
        act = Action.Modif
    End Sub

    Private Sub CmdAnnuler_Click(sender As Object, e As EventArgs) Handles CmdAnnuler.Click
        '1) Effacer toutes les anciennes erreurs
        Erp.Clear()
        '2) Barrer des contrôles
        Barrer(CmdOk, CmdAnnuler, GrpProgramme)
        '3) Débarrer des contrôles
        If LvProgramme.Items.Count > 0 Then
            Debarrer(CmdNouveau, CmdModifier, LvProgramme, LvEtuProg)
            Dim no As Integer
            no = LvProgramme.SelectedIndices(0)
            LvProgramme.SelectedIndices.Clear()
            LvProgramme.SelectedIndices.Add(no)
        Else
            Vider_Formulaire()
            CmdModifier.Enabled = False
        End If
        '4) Se positionner sur le premier champ à remplir 
        act = Action.Modif
    End Sub

    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles CmdOk.Click
        '1) Valider le formulaire 
        If Valider_Formulaire() = False Then Exit Sub
        '2) Faire l'action demandée
        If act = Action.Ajout Then
            Ajouter_Programme()
        Else
            Modifier_Programme()
        End If
    End Sub

    Private Function Valider_Formulaire() As Boolean
        Dim ok As Boolean = True
        ' Effacer les anciennes erreurs
        Erp.Clear()
        If MskNo.MaskFull = False Then
            Erp.SetError(MskNo, "Numéro du programme obligatoire")
            ok = False
        End If
        If TxtNom.Text.Trim() = "" Then
            Erp.SetError(TxtNom, "Nom du programme obligatoire")
            ok = False
        End If
        If TxtUnites.Text.Trim() = "" Then
            Erp.SetError(TxtUnites, "Nombre d'unités obligatoires")
            ok = False
        End If
        If TxtHeures.Text.Trim() = "" Then
            Erp.SetError(TxtHeures, "Nombre d'heures obligatoires")
            ok = False
        End If

        Return ok
    End Function

    Private Sub Ajouter_Programme()
        Try
            '1) Créer la commande pour ajouter un programme
            Dim ComAjout As New SqlCommand
            With ComAjout
                .CommandText = "Ajouter_Programme"
                .CommandType = CommandType.StoredProcedure
                .Connection = CnTp1
                .Parameters.AddWithValue("@no", MskNo.Text)
                .Parameters.AddWithValue("@nom", TxtNom.Text.Trim())
                .Parameters.AddWithValue("@unites", TxtUnites.Text.Trim())
                .Parameters.AddWithValue("@heures", TxtHeures.Text.Trim())
            End With
            '2)Executer la commande
            ComAjout.ExecuteNonQuery()
            '3) Donner un feedback a l'utilisateur
            MsgBox("Le programme a été ajouté avec succès...")
            '4) Remplir le ListView Programme
            Remplir_ListView_Programme()
            LvProgramme.SelectedIndices.Add(LvProgramme.Items.Count - 1)
            '5) Appeler le code du bouton Annuler
            CmdAnnuler.PerformClick()
        Catch ex As SqlException
            MsgBox(ex.Number & "" & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Modifier_Programme()
        Try
            '1) Créer la commande pour ajouter un programme
            Dim ComModif As New SqlCommand
            With ComModif
                .CommandText = "Modifier_Programme"
                .CommandType = CommandType.StoredProcedure
                .Connection = CnTp1
                .Parameters.AddWithValue("@no", MskNo.Text)
                .Parameters.AddWithValue("@nom", TxtNom.Text.Trim())
                .Parameters.AddWithValue("@unites", TxtUnites.Text.Trim())
                .Parameters.AddWithValue("@heures", TxtHeures.Text.Trim())
            End With
            '2) Exécuter la commande
            ComModif.ExecuteNonQuery()
            '3) Donner un feedback à l'utilisateur
            MsgBox("Le programme a été modifié avec succès...")
            '4) Remplir le ListView Programme
            Dim no As Integer
            no = LvProgramme.SelectedIndices(0)
            Remplir_ListView_Programme()
            LvProgramme.SelectedIndices.Add(no)
            '5) Appeler le code du bouton Annuler
            CmdAnnuler.PerformClick()
        Catch ex As SqlException
            MsgBox(ex.Number & "" & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Validation des entrées de l'utilisateur
    Private Sub Valider_Chaine(sender As Object, e As KeyPressEventArgs) Handles TxtNom.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Char.IsLetter(e.KeyChar) = False And e.KeyChar <> " " _
            And e.KeyChar <> "-" Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Valider_Nombres(sender As Object, e As KeyPressEventArgs) Handles TxtUnites.KeyPress, TxtHeures.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Char.IsDigit(e.KeyChar) = False Then
            e.KeyChar = ""
        End If
    End Sub
End Class