' Bibliothèque du Framework nécéssaire pour SQL SERVER
Imports System.Data.SqlClient

Public Class FrmEtudiants

    ' Variables globales du formulaire
    Dim CnTp1 As SqlConnection
    Dim ComEtud As SqlCommand
    Dim Dr As SqlDataReader
    Dim act As Action = Action.Aucune
    Private Sub FrmEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '1) Configurer la connexion à la base de données BD TP_p44
            CnTp1 = New SqlConnection(My.Settings.CnTp1)
            CnTp1.Open()
            '1.5) Remplir le Combo des Programmes
            Remplir_Nom_Programme()
            Remplir_Province()
            '2) Configurer la ComEtud pour récupérer les étudiants
            ComEtud = New SqlCommand("select * from T_etudiants", CnTp1)
            '3) Remplir le ListView
            Remplir_ListView_Etudiant()
            If LvEtudiant.Items.Count > 0 Then
                LvEtudiant.Focus()
                LvEtudiant.SelectedIndices.Add(0)
                CmdModifier.Enabled = True
                CmdEnlever.Enabled = True
            End If
        Catch ex As SqlException
            MsgBox(ex.Number & "" & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Remplir_Province()
        Try
            Dim ComProv As New SqlCommand("select etu_province from T_etudiants", CnTp1)
            Dr = ComProv.ExecuteReader()
            ' Boucle de Lecture 
            Do While Dr.Read()
                CboProv.Items.Add(Dr("etu_province").ToString())
            Loop
            Dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Remplir_Nom_Programme()
        Try
            Dim ComProg As New SqlCommand("select pro_no from T_programme", CnTp1)
            Dr = ComProg.ExecuteReader()
            ' Boucle de Lecture 
            Do While Dr.Read()
                CboProg.Items.Add(Dr("pro_no").ToString())
            Loop
            Dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Remplir_ListView_Etudiant()
        '1) Vider le ListView
        LvEtudiant.Items.Clear()
        '2) Créer le DataReader
        Dr = ComEtud.ExecuteReader()
        '3) Lire le contenu du DataReader et le rajouter à la listView Etudiant
        Dim Ligne As ListViewItem
        Do While Dr.Read()
            Ligne = New ListViewItem(Dr.Item("etu_da").ToString())
            Ligne.SubItems.Add(Dr.Item("pro_no").ToString())
            Ligne.SubItems.Add(Dr.Item("etu_prenom").ToString())
            Ligne.SubItems.Add(Dr.Item("etu_nom").ToString())
            Ligne.SubItems.Add(Dr.Item("etu_sexe").ToString())
            Ligne.SubItems.Add(Dr.Item("etu_adresse").ToString())
            Ligne.SubItems.Add(Dr.Item("etu_ville").ToString())
            Ligne.SubItems.Add(Dr.Item("etu_codepostal").ToString())
            Ligne.SubItems.Add(Dr.Item("etu_telephone").ToString())
            Ligne.SubItems.Add(Dr.Item("etu_province").ToString())
            Ligne.Tag = (Dr.Item("etu_da").ToString())
            LvEtudiant.Items.Add(Ligne)
        Loop
        '4) Fermer le DataReader
        Dr.Close()
    End Sub

    Private Sub LvEtudiant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvEtudiant.SelectedIndexChanged
        If LvEtudiant.SelectedItems.Count > 0 Then
            Recuperer_Etudiant(LvEtudiant.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub Recuperer_Etudiant(NoEtudiant As Integer)
        Try
            '1) Configurer la commande pour récupérer un étudiant en particulier
            Dim ComRechEtud As New SqlCommand("Select * from T_etudiants where etu_da = @etud", CnTp1)
            '2) Création et assignation d'une valeur au paramètre 
            ComRechEtud.Parameters.AddWithValue("@etud", NoEtudiant)
            '3) Créer le DataReader
            Dr = ComRechEtud.ExecuteReader()
            '4) Lecture du DataReader
            If Dr.Read() Then
                ' Assigner les valeurs au formulaire
                MskDA.Text = Dr("etu_da").ToString()
                CboProg.Text = Dr("pro_no").ToString()
                TxtPrenom.Text = Dr("etu_prenom").ToString()
                TxtNom.Text = Dr("etu_nom").ToString()
                If Dr("etu_sexe").ToString = "F" Then
                    optFem.Checked = True
                Else
                    optMas.Checked = True
                End If
                TxtAdresse.Text = Dr("etu_adresse").ToString()
                TxtVille.Text = Dr("etu_ville").ToString()
                CboProv.Text = Dr("etu_province").ToString()
                MskCP.Text = Dr("etu_codepostal").ToString()
                MskTel.Text = Dr("etu_telephone").ToString()
            End If
            '5) Fermeture du DataReader
            Dr.Close()
        Catch ex As SqlException
            MsgBox(ex.Number & "" & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmdNouveau_Click(sender As Object, e As EventArgs) Handles CmdNouveau.Click
        '1) Barrer des contrôles
        Barrer(CmdNouveau, CmdModifier, CmdEnlever, LvEtudiant)
        '2) Débarrer des contrôles
        Debarrer(CmdOk, CmdAnnuler, grpEtudiant)
        '3) Vider le formulaire
        Vider_Formulaire()
        '4) Se positionner sur le premier champ à remplir
        MskDA.Focus()
        act = Action.Ajout
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

    Private Sub Vider_Formulaire()
        MskDA.Clear()
        CboProg.SelectedIndex = -1
        TxtPrenom.Clear()
        TxtNom.Clear()
        TxtAdresse.Clear()
        optFem.Checked = False
        optMas.Checked = False
        TxtVille.Text = "Chicoutimi"
        CboProv.Text = "Québec"
        MskTel.Clear()
        MskCP.Clear()
    End Sub

    Private Sub CmdModifier_Click(sender As Object, e As EventArgs) Handles CmdModifier.Click
        '1) Barrer des contrôles
        Barrer(CmdNouveau, CmdModifier, CmdEnlever, LvEtudiant)
        '2) Débarrer des contrôles
        Debarrer(CmdOk, CmdAnnuler, grpEtudiant)
        '3) Se positionner sur le premier champ à remplir
        MskDA.Focus()
        act = Action.Modif
    End Sub

    Private Sub CmdAnnuler_Click(sender As Object, e As EventArgs) Handles CmdAnnuler.Click
        '1) Effacer les anciennes erreurs
        Erp.Clear()
        '2) Barrer des contrôles
        Barrer(CmdOk, CmdAnnuler, grpEtudiant)
        '3) Débarrer des contrôles
        If LvEtudiant.Items.Count > 0 Then
            Debarrer(CmdNouveau, CmdModifier, LvEtudiant)
            Dim no As Integer
            no = LvEtudiant.SelectedIndices(0)
            LvEtudiant.SelectedIndices.Clear()
            LvEtudiant.SelectedIndices.Add(no)
        Else
            Vider_Formulaire()
            CmdModifier.Enabled = False
        End If
        act = Action.Modif
    End Sub

    Private Sub CmdEnlever_Click(sender As Object, e As EventArgs) Handles CmdEnlever.Click
        ' Demander une confirmation à l'utilisateur avant la suppression
        Dim rep As DialogResult
        rep = MessageBox.Show("Voulez-vous supprimer cet étudiant?", "Confirmation",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Enlever_Etudiant()
        End If
    End Sub

    Private Sub Enlever_Etudiant()
        Try
            '1) Création de la commande pour faire la suppression
            Dim ComEnlever As New SqlCommand()
            With ComEnlever
                .CommandText = "Enlever_Etudiant"
                .CommandType = CommandType.StoredProcedure
                .Connection = CnTp1
                .Parameters.AddWithValue("@da", MskDA.Text)
            End With
            '2) Exécuter la commande
            If ComEnlever.ExecuteNonQuery() > 0 Then
                MsgBox("L'étudiant a été enlevé avec succès...")
            End If
            Remplir_ListView_Etudiant()
            If LvEtudiant.Items.Count > 0 Then
                LvEtudiant.SelectedIndices.Add(0)
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

    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles CmdOk.Click
        '1) Valider le formulaire s'il est bien rempli
        If Valider_Formulaire() = False Then Exit Sub
        '2) Faire l'action demandée
        If act = Action.Ajout Then
            Ajouter_Etudiant()
        Else
            Modifier_Etudiant()
        End If
    End Sub

    Private Function Valider_Formulaire() As Boolean
        Dim Ok As Boolean = True
        ' Effacer les anciennes erreurs
        Erp.Clear()
        If MskDA.MaskFull = False Then
            Erp.SetError(MskDA, "Le numéro DA est obligatoire")
            Ok = False
        End If
        If CboProg.SelectedIndex = -1 Then
            Erp.SetError(CboProg, "Le numéro du programme est obligatoire")
            Ok = False
        End If
        If TxtPrenom.Text.Trim() = "" Then
            Erp.SetError(TxtPrenom, "Le prénom est obligatoire")
            Ok = False
        End If
        If TxtNom.Text.Trim() = "" Then
            Erp.SetError(TxtNom, "Le nom est obligatoire")
            Ok = False
        End If
        If optFem.Checked = False And optMas.Checked = False Then
            Erp.SetError(optFem, "Le sexe est obligatoire")
            Ok = False
        End If
        If TxtAdresse.Text.Trim() = "" Then
            Erp.SetError(TxtAdresse, "L'adresse est obligatoire")
            Ok = False
        End If
        If TxtVille.Text.Trim() = "" Then
            Erp.SetError(TxtVille, "La ville est obligatoire")
            Ok = False
        End If
        If CboProv.Text = "" Then
            Erp.SetError(CboProv, "La province est obligatoire")
            Ok = False
        End If
        If MskCP.MaskFull = False Then
            Erp.SetError(MskCP, "Le code postal est obligatoire")
            Ok = False
        End If
        If MskTel.MaskFull = False Then
            Erp.SetError(MskTel, "Le téléphone est obligatoire")
            Ok = False
        End If

        Return Ok
    End Function

    Private Sub Ajouter_Etudiant()
        Try
            '1) Créer la commande pour ajouter un étudiant
            Dim ComAjout As New SqlCommand
            With ComAjout
                .CommandText = "Ajouter_Etudiant"
                .CommandType = CommandType.StoredProcedure
                .Connection = CnTp1
                .Parameters.AddWithValue("@da", MskDA.Text)
                .Parameters.AddWithValue("@no", CboProg.Text.Trim())
                .Parameters.AddWithValue("@prenom", TxtPrenom.Text.Trim())
                .Parameters.AddWithValue("@nom", TxtNom.Text.Trim())
                If optFem.Checked = True Then
                    .Parameters.AddWithValue("@sexe", "F")
                ElseIf optMas.Checked = True Then
                    .Parameters.AddWithValue("@sexe", "M")
                End If
                .Parameters.AddWithValue("@adr", TxtAdresse.Text.Trim())
                .Parameters.AddWithValue("@ville", TxtVille.Text.Trim())
                .Parameters.AddWithValue("@prov", CboProv.Text.Trim())
                .Parameters.AddWithValue("@cp", MskCP.Text)
                .Parameters.AddWithValue("@tel", MskTel.Text)
            End With
            '2) Exécuter la commande
            ComAjout.ExecuteNonQuery()
            '3) Donner un feedback à l'utilisateur
            MsgBox("L'étudiant a été ajouté avec succès...")
            '4) Remplir le ListView Etudiant
            Remplir_ListView_Etudiant()
            LvEtudiant.SelectedIndices.Add(LvEtudiant.Items.Count - 1)
            '5) Appeler le code du bouton Annuler
            CmdAnnuler.PerformClick()
        Catch ex As SqlException
            MsgBox(ex.Number & "" & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Modifier_Etudiant()
        Try
            '1) Créer la commande pour ajouter un étudiant
            Dim ComModif As New SqlCommand
            With ComModif
                .CommandText = "Modifier_Etudiant"
                .CommandType = CommandType.StoredProcedure
                .Connection = CnTp1
                .Parameters.AddWithValue("@da", MskDA.Text)
                .Parameters.AddWithValue("@no", CboProg.Text.Trim())
                .Parameters.AddWithValue("@prenom", TxtPrenom.Text.Trim())
                .Parameters.AddWithValue("@nom", TxtNom.Text.Trim())
                If optFem.Checked = True Then
                    .Parameters.AddWithValue("@sexe", "F")
                ElseIf optMas.Checked = True Then
                    .Parameters.AddWithValue("@sexe", "M")
                End If
                .Parameters.AddWithValue("@adr", TxtAdresse.Text.Trim())
                .Parameters.AddWithValue("@ville", TxtVille.Text.Trim())
                .Parameters.AddWithValue("@prov", CboProv.Text.Trim())
                .Parameters.AddWithValue("@cp", MskCP.Text)
                .Parameters.AddWithValue("@tel", MskTel.Text)
            End With
            '2) Exécuter la commande
            ComModif.ExecuteNonQuery()
            '3) Donner un feedback à l'utilisateur
            MsgBox("L'étudiant à été modifié avec succès...")
            '4) Remplir le ListView Etudiant
            Dim no As Integer
            no = LvEtudiant.SelectedIndices(0)
            Remplir_ListView_Etudiant()
            LvEtudiant.SelectedIndices.Add(no)
            '5) Appeler le code du bouton Annuler
            CmdAnnuler.PerformClick()
        Catch ex As SqlException
            MsgBox(ex.Number & "" & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Validation des entrées de l'utilisateur
    Private Sub Valider_Chaines(sender As Object, e As KeyPressEventArgs) Handles TxtVille.KeyPress, TxtPrenom.KeyPress, TxtNom.KeyPress, TxtAdresse.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Char.IsLetter(e.KeyChar) = False And e.KeyChar <> " " _
            And e.KeyChar <> "-" Then
            e.KeyChar = ""
        End If
    End Sub
End Class