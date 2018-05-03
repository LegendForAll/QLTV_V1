Public Class Form1
    Private Sub AddReaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddReaderToolStripMenuItem.Click
        Dim frm As Frm_AddReader = New Frm_AddReader()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
