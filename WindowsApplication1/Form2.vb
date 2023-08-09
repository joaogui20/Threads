Imports System.Threading

Public Class Form2

    Dim t As Thread

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim c As New Feyzaum
        t = New Thread(AddressOf c.prenchelista)
        c.lstTeste = lstThread
        c.id = 1
        t.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        t.Abort()
    End Sub
End Class