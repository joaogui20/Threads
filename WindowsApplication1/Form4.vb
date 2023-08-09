Imports System.Threading

Public Class Form4

    Private downloadThread As Thread
    Private isDownloading As Boolean = False

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        If Not isDownloading Then
            ' Inicializa a thread para o download
            downloadThread = New Thread(AddressOf PerformDownload)
            downloadThread.Start()

            isDownloading = True
            btnDownload.Text = "Cancelar Download"
        Else
            ' Cancela o download
            downloadThread.Abort()

            isDownloading = False
            btnDownload.Text = "Iniciar Download"
            pgrDownload.Value = 0
        End If
    End Sub

    Private Sub PerformDownload()
        Try
            For i As Integer = 1 To 100
                ' Simula o progresso do download
                Thread.Sleep(100)

                ' Atualiza a barra de progresso usando um delegado
                Me.Invoke(Sub()
                              pgrDownload.Value = i
                          End Sub)
            Next

            ' Atualiza a interface gráfica após o download
            Me.Invoke(Sub()
                          isDownloading = False
                          btnDownload.Text = "Download Concluído"
                      End Sub)
        Catch ex As ThreadAbortException
            ' Tratamento da exceção de cancelamento da thread
            Me.Invoke(Sub()
                          pgrDownload.Value = 0
                          isDownloading = False
                          btnDownload.Text = "Download Cancelado"
                      End Sub)
        End Try
    End Sub
End Class