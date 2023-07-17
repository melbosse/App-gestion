<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEtudiants
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GrpOperation = New System.Windows.Forms.GroupBox()
        Me.CmdEnlever = New System.Windows.Forms.Button()
        Me.CmdModifier = New System.Windows.Forms.Button()
        Me.CmdAnnuler = New System.Windows.Forms.Button()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.CmdNouveau = New System.Windows.Forms.Button()
        Me.LvEtudiant = New System.Windows.Forms.ListView()
        Me.ColDA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNoProg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPrenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSexe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColAdresse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColVille = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColCP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColTel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColProvince = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LbDA = New System.Windows.Forms.Label()
        Me.LblPrenom = New System.Windows.Forms.Label()
        Me.TxtPrenom = New System.Windows.Forms.TextBox()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.LblAdresse = New System.Windows.Forms.Label()
        Me.LblVille = New System.Windows.Forms.Label()
        Me.TxtVille = New System.Windows.Forms.TextBox()
        Me.LblCodePostal = New System.Windows.Forms.Label()
        Me.MskCP = New System.Windows.Forms.MaskedTextBox()
        Me.LblTel = New System.Windows.Forms.Label()
        Me.MskTel = New System.Windows.Forms.MaskedTextBox()
        Me.LblProvince = New System.Windows.Forms.Label()
        Me.TxtAdresse = New System.Windows.Forms.TextBox()
        Me.GrpSexe = New System.Windows.Forms.GroupBox()
        Me.optMas = New System.Windows.Forms.RadioButton()
        Me.optFem = New System.Windows.Forms.RadioButton()
        Me.MskDA = New System.Windows.Forms.MaskedTextBox()
        Me.LblNoProg = New System.Windows.Forms.Label()
        Me.grpEtudiant = New System.Windows.Forms.GroupBox()
        Me.CboProv = New System.Windows.Forms.ComboBox()
        Me.CboProg = New System.Windows.Forms.ComboBox()
        Me.Erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GrpOperation.SuspendLayout()
        Me.GrpSexe.SuspendLayout()
        Me.grpEtudiant.SuspendLayout()
        CType(Me.Erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpOperation
        '
        Me.GrpOperation.Controls.Add(Me.CmdEnlever)
        Me.GrpOperation.Controls.Add(Me.CmdModifier)
        Me.GrpOperation.Controls.Add(Me.CmdAnnuler)
        Me.GrpOperation.Controls.Add(Me.CmdOk)
        Me.GrpOperation.Controls.Add(Me.CmdNouveau)
        Me.GrpOperation.Location = New System.Drawing.Point(603, 6)
        Me.GrpOperation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GrpOperation.Name = "GrpOperation"
        Me.GrpOperation.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GrpOperation.Size = New System.Drawing.Size(104, 175)
        Me.GrpOperation.TabIndex = 4
        Me.GrpOperation.TabStop = False
        '
        'CmdEnlever
        '
        Me.CmdEnlever.BackColor = System.Drawing.SystemColors.Control
        Me.CmdEnlever.Enabled = False
        Me.CmdEnlever.Location = New System.Drawing.Point(10, 139)
        Me.CmdEnlever.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmdEnlever.Name = "CmdEnlever"
        Me.CmdEnlever.Size = New System.Drawing.Size(85, 23)
        Me.CmdEnlever.TabIndex = 4
        Me.CmdEnlever.Text = "Enlever"
        Me.CmdEnlever.UseVisualStyleBackColor = False
        '
        'CmdModifier
        '
        Me.CmdModifier.BackColor = System.Drawing.SystemColors.Control
        Me.CmdModifier.Enabled = False
        Me.CmdModifier.Location = New System.Drawing.Point(10, 107)
        Me.CmdModifier.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmdModifier.Name = "CmdModifier"
        Me.CmdModifier.Size = New System.Drawing.Size(85, 23)
        Me.CmdModifier.TabIndex = 3
        Me.CmdModifier.Text = "Modifier"
        Me.CmdModifier.UseVisualStyleBackColor = False
        '
        'CmdAnnuler
        '
        Me.CmdAnnuler.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAnnuler.Enabled = False
        Me.CmdAnnuler.Location = New System.Drawing.Point(10, 75)
        Me.CmdAnnuler.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmdAnnuler.Name = "CmdAnnuler"
        Me.CmdAnnuler.Size = New System.Drawing.Size(85, 23)
        Me.CmdAnnuler.TabIndex = 2
        Me.CmdAnnuler.Text = "Annuler"
        Me.CmdAnnuler.UseVisualStyleBackColor = False
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.CmdOk.Enabled = False
        Me.CmdOk.Location = New System.Drawing.Point(10, 44)
        Me.CmdOk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(85, 23)
        Me.CmdOk.TabIndex = 1
        Me.CmdOk.Text = "OK"
        Me.CmdOk.UseVisualStyleBackColor = False
        '
        'CmdNouveau
        '
        Me.CmdNouveau.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNouveau.Location = New System.Drawing.Point(10, 15)
        Me.CmdNouveau.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmdNouveau.Name = "CmdNouveau"
        Me.CmdNouveau.Size = New System.Drawing.Size(85, 23)
        Me.CmdNouveau.TabIndex = 0
        Me.CmdNouveau.Text = "Nouveau"
        Me.CmdNouveau.UseVisualStyleBackColor = False
        '
        'LvEtudiant
        '
        Me.LvEtudiant.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColDA, Me.ColNoProg, Me.ColPrenom, Me.ColNom, Me.ColSexe, Me.ColAdresse, Me.ColVille, Me.ColCP, Me.ColTel, Me.ColProvince})
        Me.LvEtudiant.FullRowSelect = True
        Me.LvEtudiant.GridLines = True
        Me.LvEtudiant.HideSelection = False
        Me.LvEtudiant.Location = New System.Drawing.Point(4, 191)
        Me.LvEtudiant.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LvEtudiant.MultiSelect = False
        Me.LvEtudiant.Name = "LvEtudiant"
        Me.LvEtudiant.Size = New System.Drawing.Size(705, 241)
        Me.LvEtudiant.TabIndex = 5
        Me.LvEtudiant.UseCompatibleStateImageBehavior = False
        Me.LvEtudiant.View = System.Windows.Forms.View.Details
        '
        'ColDA
        '
        Me.ColDA.Text = "DA"
        Me.ColDA.Width = 70
        '
        'ColNoProg
        '
        Me.ColNoProg.Text = "No Prog."
        Me.ColNoProg.Width = 98
        '
        'ColPrenom
        '
        Me.ColPrenom.Text = "Prénom"
        Me.ColPrenom.Width = 92
        '
        'ColNom
        '
        Me.ColNom.Text = "Nom"
        Me.ColNom.Width = 64
        '
        'ColSexe
        '
        Me.ColSexe.Text = "Sexe"
        Me.ColSexe.Width = 65
        '
        'ColAdresse
        '
        Me.ColAdresse.Text = "Adresse"
        Me.ColAdresse.Width = 114
        '
        'ColVille
        '
        Me.ColVille.Text = "Ville"
        Me.ColVille.Width = 81
        '
        'ColCP
        '
        Me.ColCP.Text = "Code Postal"
        Me.ColCP.Width = 129
        '
        'ColTel
        '
        Me.ColTel.Text = "Téléphone"
        Me.ColTel.Width = 132
        '
        'ColProvince
        '
        Me.ColProvince.Text = "Province"
        Me.ColProvince.Width = 108
        '
        'LbDA
        '
        Me.LbDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbDA.Location = New System.Drawing.Point(14, 16)
        Me.LbDA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbDA.Name = "LbDA"
        Me.LbDA.Size = New System.Drawing.Size(70, 17)
        Me.LbDA.TabIndex = 0
        Me.LbDA.Text = "DA:"
        '
        'LblPrenom
        '
        Me.LblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPrenom.Location = New System.Drawing.Point(14, 63)
        Me.LblPrenom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrenom.Name = "LblPrenom"
        Me.LblPrenom.Size = New System.Drawing.Size(70, 17)
        Me.LblPrenom.TabIndex = 2
        Me.LblPrenom.Text = "Prénom:"
        '
        'TxtPrenom
        '
        Me.TxtPrenom.Location = New System.Drawing.Point(89, 64)
        Me.TxtPrenom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPrenom.MaxLength = 20
        Me.TxtPrenom.Name = "TxtPrenom"
        Me.TxtPrenom.Size = New System.Drawing.Size(178, 20)
        Me.TxtPrenom.TabIndex = 3
        '
        'LblNom
        '
        Me.LblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNom.Location = New System.Drawing.Point(14, 87)
        Me.LblNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(70, 17)
        Me.LblNom.TabIndex = 4
        Me.LblNom.Text = "Nom:"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(88, 87)
        Me.TxtNom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNom.MaxLength = 20
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(178, 20)
        Me.TxtNom.TabIndex = 5
        '
        'LblAdresse
        '
        Me.LblAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAdresse.Location = New System.Drawing.Point(288, 14)
        Me.LblAdresse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAdresse.Name = "LblAdresse"
        Me.LblAdresse.Size = New System.Drawing.Size(70, 17)
        Me.LblAdresse.TabIndex = 6
        Me.LblAdresse.Text = "Adresse:"
        '
        'LblVille
        '
        Me.LblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVille.Location = New System.Drawing.Point(288, 41)
        Me.LblVille.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblVille.Name = "LblVille"
        Me.LblVille.Size = New System.Drawing.Size(70, 17)
        Me.LblVille.TabIndex = 18
        Me.LblVille.Text = "Ville:"
        '
        'TxtVille
        '
        Me.TxtVille.Location = New System.Drawing.Point(372, 36)
        Me.TxtVille.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtVille.MaxLength = 50
        Me.TxtVille.Name = "TxtVille"
        Me.TxtVille.Size = New System.Drawing.Size(210, 20)
        Me.TxtVille.TabIndex = 19
        '
        'LblCodePostal
        '
        Me.LblCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCodePostal.Location = New System.Drawing.Point(288, 90)
        Me.LblCodePostal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCodePostal.Name = "LblCodePostal"
        Me.LblCodePostal.Size = New System.Drawing.Size(70, 17)
        Me.LblCodePostal.TabIndex = 20
        Me.LblCodePostal.Text = "Code Postal:"
        '
        'MskCP
        '
        Me.MskCP.Location = New System.Drawing.Point(372, 89)
        Me.MskCP.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MskCP.Mask = "L9L-9L9"
        Me.MskCP.Name = "MskCP"
        Me.MskCP.Size = New System.Drawing.Size(106, 20)
        Me.MskCP.TabIndex = 21
        '
        'LblTel
        '
        Me.LblTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTel.Location = New System.Drawing.Point(288, 117)
        Me.LblTel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTel.Name = "LblTel"
        Me.LblTel.Size = New System.Drawing.Size(70, 17)
        Me.LblTel.TabIndex = 22
        Me.LblTel.Text = "Téléphone:"
        '
        'MskTel
        '
        Me.MskTel.Location = New System.Drawing.Point(372, 113)
        Me.MskTel.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MskTel.Mask = "(999) 999-9999"
        Me.MskTel.Name = "MskTel"
        Me.MskTel.Size = New System.Drawing.Size(106, 20)
        Me.MskTel.TabIndex = 23
        '
        'LblProvince
        '
        Me.LblProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProvince.Location = New System.Drawing.Point(288, 65)
        Me.LblProvince.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblProvince.Name = "LblProvince"
        Me.LblProvince.Size = New System.Drawing.Size(70, 17)
        Me.LblProvince.TabIndex = 24
        Me.LblProvince.Text = "Province:"
        '
        'TxtAdresse
        '
        Me.TxtAdresse.Location = New System.Drawing.Point(372, 15)
        Me.TxtAdresse.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtAdresse.MaxLength = 100
        Me.TxtAdresse.Name = "TxtAdresse"
        Me.TxtAdresse.Size = New System.Drawing.Size(210, 20)
        Me.TxtAdresse.TabIndex = 7
        '
        'GrpSexe
        '
        Me.GrpSexe.Controls.Add(Me.optMas)
        Me.GrpSexe.Controls.Add(Me.optFem)
        Me.GrpSexe.Location = New System.Drawing.Point(88, 107)
        Me.GrpSexe.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GrpSexe.Name = "GrpSexe"
        Me.GrpSexe.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GrpSexe.Size = New System.Drawing.Size(104, 63)
        Me.GrpSexe.TabIndex = 28
        Me.GrpSexe.TabStop = False
        Me.GrpSexe.Text = "Sexe"
        '
        'optMas
        '
        Me.optMas.AutoSize = True
        Me.optMas.Location = New System.Drawing.Point(14, 39)
        Me.optMas.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.optMas.Name = "optMas"
        Me.optMas.Size = New System.Drawing.Size(67, 17)
        Me.optMas.TabIndex = 1
        Me.optMas.TabStop = True
        Me.optMas.Text = "Masculin"
        Me.optMas.UseVisualStyleBackColor = True
        '
        'optFem
        '
        Me.optFem.AutoSize = True
        Me.optFem.Location = New System.Drawing.Point(14, 16)
        Me.optFem.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.optFem.Name = "optFem"
        Me.optFem.Size = New System.Drawing.Size(61, 17)
        Me.optFem.TabIndex = 0
        Me.optFem.TabStop = True
        Me.optFem.Text = "Féminin"
        Me.optFem.UseVisualStyleBackColor = True
        '
        'MskDA
        '
        Me.MskDA.Location = New System.Drawing.Point(90, 17)
        Me.MskDA.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MskDA.Mask = "9999999"
        Me.MskDA.Name = "MskDA"
        Me.MskDA.Size = New System.Drawing.Size(90, 20)
        Me.MskDA.TabIndex = 29
        '
        'LblNoProg
        '
        Me.LblNoProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNoProg.Location = New System.Drawing.Point(14, 41)
        Me.LblNoProg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNoProg.Name = "LblNoProg"
        Me.LblNoProg.Size = New System.Drawing.Size(70, 17)
        Me.LblNoProg.TabIndex = 31
        Me.LblNoProg.Text = "No Prog:"
        '
        'grpEtudiant
        '
        Me.grpEtudiant.BackColor = System.Drawing.SystemColors.Window
        Me.grpEtudiant.Controls.Add(Me.CboProv)
        Me.grpEtudiant.Controls.Add(Me.CboProg)
        Me.grpEtudiant.Controls.Add(Me.LblNoProg)
        Me.grpEtudiant.Controls.Add(Me.MskDA)
        Me.grpEtudiant.Controls.Add(Me.GrpSexe)
        Me.grpEtudiant.Controls.Add(Me.TxtAdresse)
        Me.grpEtudiant.Controls.Add(Me.LblProvince)
        Me.grpEtudiant.Controls.Add(Me.MskTel)
        Me.grpEtudiant.Controls.Add(Me.LblTel)
        Me.grpEtudiant.Controls.Add(Me.MskCP)
        Me.grpEtudiant.Controls.Add(Me.LblCodePostal)
        Me.grpEtudiant.Controls.Add(Me.TxtVille)
        Me.grpEtudiant.Controls.Add(Me.LblVille)
        Me.grpEtudiant.Controls.Add(Me.LblAdresse)
        Me.grpEtudiant.Controls.Add(Me.TxtNom)
        Me.grpEtudiant.Controls.Add(Me.LblNom)
        Me.grpEtudiant.Controls.Add(Me.TxtPrenom)
        Me.grpEtudiant.Controls.Add(Me.LblPrenom)
        Me.grpEtudiant.Controls.Add(Me.LbDA)
        Me.grpEtudiant.Enabled = False
        Me.grpEtudiant.Location = New System.Drawing.Point(12, 7)
        Me.grpEtudiant.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.grpEtudiant.Name = "grpEtudiant"
        Me.grpEtudiant.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.grpEtudiant.Size = New System.Drawing.Size(588, 174)
        Me.grpEtudiant.TabIndex = 1
        Me.grpEtudiant.TabStop = False
        Me.grpEtudiant.Text = "Etudiant"
        '
        'CboProv
        '
        Me.CboProv.FormattingEnabled = True
        Me.CboProv.Location = New System.Drawing.Point(372, 63)
        Me.CboProv.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.CboProv.Name = "CboProv"
        Me.CboProv.Size = New System.Drawing.Size(106, 21)
        Me.CboProv.TabIndex = 34
        '
        'CboProg
        '
        Me.CboProg.FormattingEnabled = True
        Me.CboProg.Location = New System.Drawing.Point(90, 41)
        Me.CboProg.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.CboProg.MaxLength = 6
        Me.CboProg.Name = "CboProg"
        Me.CboProg.Size = New System.Drawing.Size(94, 21)
        Me.CboProg.TabIndex = 32
        '
        'Erp
        '
        Me.Erp.ContainerControl = Me
        '
        'FrmEtudiants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(723, 461)
        Me.Controls.Add(Me.LvEtudiant)
        Me.Controls.Add(Me.GrpOperation)
        Me.Controls.Add(Me.grpEtudiant)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "FrmEtudiants"
        Me.Text = "FrmEtudiants"
        Me.GrpOperation.ResumeLayout(False)
        Me.GrpSexe.ResumeLayout(False)
        Me.GrpSexe.PerformLayout()
        Me.grpEtudiant.ResumeLayout(False)
        Me.grpEtudiant.PerformLayout()
        CType(Me.Erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpOperation As GroupBox
    Friend WithEvents CmdEnlever As Button
    Friend WithEvents CmdModifier As Button
    Friend WithEvents CmdAnnuler As Button
    Friend WithEvents CmdOk As Button
    Friend WithEvents CmdNouveau As Button
    Friend WithEvents LvEtudiant As ListView
    Friend WithEvents ColDA As ColumnHeader
    Friend WithEvents ColNoProg As ColumnHeader
    Friend WithEvents ColPrenom As ColumnHeader
    Friend WithEvents ColNom As ColumnHeader
    Friend WithEvents ColSexe As ColumnHeader
    Friend WithEvents ColAdresse As ColumnHeader
    Friend WithEvents ColVille As ColumnHeader
    Friend WithEvents ColCP As ColumnHeader
    Friend WithEvents ColTel As ColumnHeader
    Friend WithEvents ColProvince As ColumnHeader
    Friend WithEvents LbDA As Label
    Friend WithEvents LblPrenom As Label
    Friend WithEvents TxtPrenom As TextBox
    Friend WithEvents LblNom As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents LblAdresse As Label
    Friend WithEvents LblVille As Label
    Friend WithEvents TxtVille As TextBox
    Friend WithEvents LblCodePostal As Label
    Friend WithEvents MskCP As MaskedTextBox
    Friend WithEvents LblTel As Label
    Friend WithEvents MskTel As MaskedTextBox
    Friend WithEvents LblProvince As Label
    Friend WithEvents TxtAdresse As TextBox
    Friend WithEvents GrpSexe As GroupBox
    Friend WithEvents optMas As RadioButton
    Friend WithEvents optFem As RadioButton
    Friend WithEvents MskDA As MaskedTextBox
    Friend WithEvents LblNoProg As Label
    Friend WithEvents grpEtudiant As GroupBox
    Friend WithEvents CboProg As ComboBox
    Friend WithEvents CboProv As ComboBox
    Friend WithEvents Erp As ErrorProvider
End Class
