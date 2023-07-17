<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.MnuGestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuProgramme = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEtudiants = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mnutrait = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuRapport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuListProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuListEtu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuListEtuProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuPrincipal
        '
        Me.MnuPrincipal.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuGestion, Me.MnuRapport})
        Me.MnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MnuPrincipal.Name = "MnuPrincipal"
        Me.MnuPrincipal.Padding = New System.Windows.Forms.Padding(11, 5, 0, 5)
        Me.MnuPrincipal.Size = New System.Drawing.Size(1104, 29)
        Me.MnuPrincipal.TabIndex = 1
        '
        'MnuGestion
        '
        Me.MnuGestion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuProgramme, Me.MnuEtudiants, Me.Mnutrait, Me.MnuQuitter})
        Me.MnuGestion.Name = "MnuGestion"
        Me.MnuGestion.Size = New System.Drawing.Size(59, 19)
        Me.MnuGestion.Text = "Gestion"
        '
        'MnuProgramme
        '
        Me.MnuProgramme.Name = "MnuProgramme"
        Me.MnuProgramme.Size = New System.Drawing.Size(180, 22)
        Me.MnuProgramme.Text = "Programme"
        '
        'MnuEtudiants
        '
        Me.MnuEtudiants.Name = "MnuEtudiants"
        Me.MnuEtudiants.Size = New System.Drawing.Size(180, 22)
        Me.MnuEtudiants.Text = "Etudiants"
        '
        'Mnutrait
        '
        Me.Mnutrait.Name = "Mnutrait"
        Me.Mnutrait.Size = New System.Drawing.Size(177, 6)
        '
        'MnuQuitter
        '
        Me.MnuQuitter.Name = "MnuQuitter"
        Me.MnuQuitter.Size = New System.Drawing.Size(180, 22)
        Me.MnuQuitter.Text = "Quitter"
        '
        'MnuRapport
        '
        Me.MnuRapport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuListProg, Me.MnuListEtu, Me.MnuListEtuProg})
        Me.MnuRapport.Name = "MnuRapport"
        Me.MnuRapport.Size = New System.Drawing.Size(61, 19)
        Me.MnuRapport.Text = "Rapport"
        '
        'MnuListProg
        '
        Me.MnuListProg.Name = "MnuListProg"
        Me.MnuListProg.Size = New System.Drawing.Size(257, 22)
        Me.MnuListProg.Text = "Liste des Programmes"
        '
        'MnuListEtu
        '
        Me.MnuListEtu.Name = "MnuListEtu"
        Me.MnuListEtu.Size = New System.Drawing.Size(257, 22)
        Me.MnuListEtu.Text = "Liste des Etudiants"
        '
        'MnuListEtuProg
        '
        Me.MnuListEtuProg.Name = "MnuListEtuProg"
        Me.MnuListEtuProg.Size = New System.Drawing.Size(257, 22)
        Me.MnuListEtuProg.Text = "Liste des etudiants par programme"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 801)
        Me.Controls.Add(Me.MnuPrincipal)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MnuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.Text = "Gestion"
        Me.MnuPrincipal.ResumeLayout(False)
        Me.MnuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuPrincipal As MenuStrip
    Friend WithEvents MnuGestion As ToolStripMenuItem
    Friend WithEvents MnuProgramme As ToolStripMenuItem
    Friend WithEvents MnuEtudiants As ToolStripMenuItem
    Friend WithEvents MnuRapport As ToolStripMenuItem
    Friend WithEvents MnuListProg As ToolStripMenuItem
    Friend WithEvents MnuListEtu As ToolStripMenuItem
    Friend WithEvents MnuListEtuProg As ToolStripMenuItem
    Friend WithEvents Mnutrait As ToolStripSeparator
    Friend WithEvents MnuQuitter As ToolStripMenuItem
End Class
