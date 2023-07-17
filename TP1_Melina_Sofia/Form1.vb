Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MnuProgramme_Click(sender As Object, e As EventArgs) Handles MnuProgramme.Click
        FrmProgramme.MdiParent = Me
        FrmProgramme.Show()
    End Sub

    Private Sub MnuEtudiants_Click(sender As Object, e As EventArgs) Handles MnuEtudiants.Click
        FrmEtudiants.MdiParent = Me
        FrmEtudiants.Show()
    End Sub

    Private Sub MnuQuitter_Click(sender As Object, e As EventArgs) Handles MnuQuitter.Click
        ' Demander à l'utilisateur s'il désire quitter l'application
        Dim rep As DialogResult
        rep = MessageBox.Show("Désirez-vous quitter l'application?", "Confirmation",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
