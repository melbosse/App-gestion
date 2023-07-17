<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProgramme
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GrpOperation = New System.Windows.Forms.GroupBox()
        Me.CmdEnlever = New System.Windows.Forms.Button()
        Me.CmdModifier = New System.Windows.Forms.Button()
        Me.CmdAnnuler = New System.Windows.Forms.Button()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.CmdNouveau = New System.Windows.Forms.Button()
        Me.LvProgramme = New System.Windows.Forms.ListView()
        Me.ColNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColUnites = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColHeures = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LvEtuProg = New System.Windows.Forms.ListView()
        Me.ColDA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNoProg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPrenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNom1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GrpProgramme = New System.Windows.Forms.GroupBox()
        Me.MskNo = New System.Windows.Forms.MaskedTextBox()
        Me.TxtHeures = New System.Windows.Forms.TextBox()
        Me.LblHeures = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.TxtUnites = New System.Windows.Forms.TextBox()
        Me.LblUnites = New System.Windows.Forms.Label()
        Me.LblNo = New System.Windows.Forms.Label()
        Me.Erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GrpOperation.SuspendLayout()
        Me.GrpProgramme.SuspendLayout()
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
        Me.GrpOperation.Location = New System.Drawing.Point(411, 35)
        Me.GrpOperation.Name = "GrpOperation"
        Me.GrpOperation.Size = New System.Drawing.Size(225, 288)
        Me.GrpOperation.TabIndex = 4
        Me.GrpOperation.TabStop = False
        '
        'CmdEnlever
        '
        Me.CmdEnlever.BackColor = System.Drawing.SystemColors.Control
        Me.CmdEnlever.Enabled = False
        Me.CmdEnlever.Location = New System.Drawing.Point(21, 224)
        Me.CmdEnlever.Name = "CmdEnlever"
        Me.CmdEnlever.Size = New System.Drawing.Size(177, 43)
        Me.CmdEnlever.TabIndex = 4
        Me.CmdEnlever.Text = "Enlever"
        Me.CmdEnlever.UseVisualStyleBackColor = False
        '
        'CmdModifier
        '
        Me.CmdModifier.BackColor = System.Drawing.SystemColors.Control
        Me.CmdModifier.Enabled = False
        Me.CmdModifier.Location = New System.Drawing.Point(21, 175)
        Me.CmdModifier.Name = "CmdModifier"
        Me.CmdModifier.Size = New System.Drawing.Size(177, 43)
        Me.CmdModifier.TabIndex = 3
        Me.CmdModifier.Text = "Modifier"
        Me.CmdModifier.UseVisualStyleBackColor = False
        '
        'CmdAnnuler
        '
        Me.CmdAnnuler.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAnnuler.Enabled = False
        Me.CmdAnnuler.Location = New System.Drawing.Point(21, 126)
        Me.CmdAnnuler.Name = "CmdAnnuler"
        Me.CmdAnnuler.Size = New System.Drawing.Size(177, 43)
        Me.CmdAnnuler.TabIndex = 2
        Me.CmdAnnuler.Text = "Annuler"
        Me.CmdAnnuler.UseVisualStyleBackColor = False
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.CmdOk.Enabled = False
        Me.CmdOk.Location = New System.Drawing.Point(21, 77)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(177, 43)
        Me.CmdOk.TabIndex = 1
        Me.CmdOk.Text = "OK"
        Me.CmdOk.UseVisualStyleBackColor = False
        '
        'CmdNouveau
        '
        Me.CmdNouveau.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNouveau.Location = New System.Drawing.Point(21, 28)
        Me.CmdNouveau.Name = "CmdNouveau"
        Me.CmdNouveau.Size = New System.Drawing.Size(177, 43)
        Me.CmdNouveau.TabIndex = 0
        Me.CmdNouveau.Text = "Nouveau"
        Me.CmdNouveau.UseVisualStyleBackColor = False
        '
        'LvProgramme
        '
        Me.LvProgramme.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColNum, Me.ColNom, Me.ColUnites, Me.ColHeures})
        Me.LvProgramme.FullRowSelect = True
        Me.LvProgramme.GridLines = True
        Me.LvProgramme.HideSelection = False
        Me.LvProgramme.Location = New System.Drawing.Point(12, 340)
        Me.LvProgramme.MultiSelect = False
        Me.LvProgramme.Name = "LvProgramme"
        Me.LvProgramme.Size = New System.Drawing.Size(624, 328)
        Me.LvProgramme.TabIndex = 5
        Me.LvProgramme.UseCompatibleStateImageBehavior = False
        Me.LvProgramme.View = System.Windows.Forms.View.Details
        '
        'ColNum
        '
        Me.ColNum.Text = "No"
        Me.ColNum.Width = 103
        '
        'ColNom
        '
        Me.ColNom.Text = "Nom"
        Me.ColNom.Width = 112
        '
        'ColUnites
        '
        Me.ColUnites.Text = "Nbr. Unités"
        Me.ColUnites.Width = 163
        '
        'ColHeures
        '
        Me.ColHeures.Text = "Nbr. Heures"
        Me.ColHeures.Width = 201
        '
        'LvEtuProg
        '
        Me.LvEtuProg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColDA, Me.ColNoProg, Me.ColPrenom, Me.ColNom1})
        Me.LvEtuProg.FullRowSelect = True
        Me.LvEtuProg.GridLines = True
        Me.LvEtuProg.HideSelection = False
        Me.LvEtuProg.Location = New System.Drawing.Point(653, 46)
        Me.LvEtuProg.MultiSelect = False
        Me.LvEtuProg.Name = "LvEtuProg"
        Me.LvEtuProg.Size = New System.Drawing.Size(455, 622)
        Me.LvEtuProg.TabIndex = 6
        Me.LvEtuProg.UseCompatibleStateImageBehavior = False
        Me.LvEtuProg.View = System.Windows.Forms.View.Details
        '
        'ColDA
        '
        Me.ColDA.Text = "DA"
        Me.ColDA.Width = 91
        '
        'ColNoProg
        '
        Me.ColNoProg.Text = "No Prog."
        Me.ColNoProg.Width = 105
        '
        'ColPrenom
        '
        Me.ColPrenom.Text = "Prénom"
        Me.ColPrenom.Width = 139
        '
        'ColNom1
        '
        Me.ColNom1.Text = "Nom"
        Me.ColNom1.Width = 258
        '
        'GrpProgramme
        '
        Me.GrpProgramme.Controls.Add(Me.MskNo)
        Me.GrpProgramme.Controls.Add(Me.TxtHeures)
        Me.GrpProgramme.Controls.Add(Me.LblHeures)
        Me.GrpProgramme.Controls.Add(Me.TxtNom)
        Me.GrpProgramme.Controls.Add(Me.LblNom)
        Me.GrpProgramme.Controls.Add(Me.TxtUnites)
        Me.GrpProgramme.Controls.Add(Me.LblUnites)
        Me.GrpProgramme.Controls.Add(Me.LblNo)
        Me.GrpProgramme.Enabled = False
        Me.GrpProgramme.Location = New System.Drawing.Point(12, 35)
        Me.GrpProgramme.Name = "GrpProgramme"
        Me.GrpProgramme.Size = New System.Drawing.Size(380, 288)
        Me.GrpProgramme.TabIndex = 7
        Me.GrpProgramme.TabStop = False
        Me.GrpProgramme.Text = "Programme"
        '
        'MskNo
        '
        Me.MskNo.Location = New System.Drawing.Point(184, 40)
        Me.MskNo.Mask = "LLL.0L"
        Me.MskNo.Name = "MskNo"
        Me.MskNo.Size = New System.Drawing.Size(93, 19)
        Me.MskNo.TabIndex = 8
        '
        'TxtHeures
        '
        Me.TxtHeures.Location = New System.Drawing.Point(184, 203)
        Me.TxtHeures.MaxLength = 150
        Me.TxtHeures.Name = "TxtHeures"
        Me.TxtHeures.Size = New System.Drawing.Size(93, 19)
        Me.TxtHeures.TabIndex = 7
        '
        'LblHeures
        '
        Me.LblHeures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblHeures.Location = New System.Drawing.Point(30, 187)
        Me.LblHeures.Name = "LblHeures"
        Me.LblHeures.Size = New System.Drawing.Size(138, 47)
        Me.LblHeures.TabIndex = 6
        Me.LblHeures.Text = "Nbr: Heures:"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(184, 89)
        Me.TxtNom.MaxLength = 50
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(187, 19)
        Me.TxtNom.TabIndex = 5
        '
        'LblNom
        '
        Me.LblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNom.Location = New System.Drawing.Point(29, 85)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(138, 47)
        Me.LblNom.TabIndex = 4
        Me.LblNom.Text = "Nom:"
        '
        'TxtUnites
        '
        Me.TxtUnites.Location = New System.Drawing.Point(184, 150)
        Me.TxtUnites.MaxLength = 50
        Me.TxtUnites.Name = "TxtUnites"
        Me.TxtUnites.Size = New System.Drawing.Size(93, 19)
        Me.TxtUnites.TabIndex = 3
        '
        'LblUnites
        '
        Me.LblUnites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblUnites.Location = New System.Drawing.Point(29, 136)
        Me.LblUnites.Name = "LblUnites"
        Me.LblUnites.Size = New System.Drawing.Size(138, 45)
        Me.LblUnites.TabIndex = 2
        Me.LblUnites.Text = "Nbr. Unités:"
        '
        'LblNo
        '
        Me.LblNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNo.Location = New System.Drawing.Point(29, 29)
        Me.LblNo.Name = "LblNo"
        Me.LblNo.Size = New System.Drawing.Size(138, 49)
        Me.LblNo.TabIndex = 0
        Me.LblNo.Text = "No:"
        '
        'Erp
        '
        Me.Erp.ContainerControl = Me
        '
        'FrmProgramme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1126, 699)
        Me.Controls.Add(Me.GrpProgramme)
        Me.Controls.Add(Me.LvEtuProg)
        Me.Controls.Add(Me.LvProgramme)
        Me.Controls.Add(Me.GrpOperation)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmProgramme"
        Me.Text = "Programme"
        Me.GrpOperation.ResumeLayout(False)
        Me.GrpProgramme.ResumeLayout(False)
        Me.GrpProgramme.PerformLayout()
        CType(Me.Erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpOperation As GroupBox
    Friend WithEvents CmdEnlever As Button
    Friend WithEvents CmdModifier As Button
    Friend WithEvents CmdAnnuler As Button
    Friend WithEvents CmdOk As Button
    Friend WithEvents CmdNouveau As Button
    Friend WithEvents LvProgramme As ListView
    Friend WithEvents LvEtuProg As ListView
    Friend WithEvents GrpProgramme As GroupBox
    Friend WithEvents TxtHeures As TextBox
    Friend WithEvents LblHeures As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents LblNom As Label
    Friend WithEvents TxtUnites As TextBox
    Friend WithEvents LblUnites As Label
    Friend WithEvents LblNo As Label
    Friend WithEvents ColNum As ColumnHeader
    Friend WithEvents ColNom As ColumnHeader
    Friend WithEvents ColUnites As ColumnHeader
    Friend WithEvents ColHeures As ColumnHeader
    Friend WithEvents ColDA As ColumnHeader
    Friend WithEvents ColNoProg As ColumnHeader
    Friend WithEvents ColPrenom As ColumnHeader
    Friend WithEvents ColNom1 As ColumnHeader
    Friend WithEvents MskNo As MaskedTextBox
    Friend WithEvents Erp As ErrorProvider
End Class
