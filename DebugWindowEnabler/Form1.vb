Imports CV
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DebugWindow As New CV.A_Test_Thing
        DebugWindow.Show()
        Close()
    End Sub
End Class