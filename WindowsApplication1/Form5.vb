Imports System.Threading

Public Class Form5

    Private countdownThread As Thread
    Private countdownValue As Integer = 10

    Public Sub PerformCountdown()
        While countdownValue > 0
            ' Atualiza a interface gráfica usando um delegado
            Me.Invoke(Sub()
                          lblCountdown.Text = countdownValue.ToString()
                      End Sub)

            ' Simula a contagem regressiva
            Thread.Sleep(1000)

            countdownValue -= 1
        End While

        ' Atualiza a interface gráfica após a contagem regressiva
        Me.Invoke(Sub()
                      lblCountdown.Text = "Contagem regressiva concluída!"
                  End Sub)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Inicializa a thread para a contagem regressiva
        countdownThread = New Thread(AddressOf PerformCountdown)
        countdownThread.Start()
    End Sub

    Private Sub Form5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Certifica-se de que a thread seja encerrada ao fechar o formulário
        If countdownThread IsNot Nothing AndAlso countdownThread.IsAlive Then
            countdownThread.Abort()
        End If
    End Sub
End Class