Imports System.Threading

Public Class Form6

    Dim thread1 As Thread

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        'MessageBox.Show("Mensagem ativa")
        thread1 = New Thread(AddressOf mostrarMensagem)
        thread1.Start()
    End Sub

    Private Sub mostrarMensagem()
        MessageBox.Show("Thread ativa")
    End Sub
End Class