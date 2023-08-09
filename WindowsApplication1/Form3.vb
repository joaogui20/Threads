Imports System.Threading

Public Class Form3

    Dim t As Thread
    Dim WithEvents oArea As cAreaQuadrado

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        oArea = New cAreaQuadrado
        t = New Thread(AddressOf oArea.CalculaArea)
        oArea.Lado = 30
        t.Start()

        If t.Join(500) Then
            MsgBox(oArea.Area)
        End If
    End Sub

    Sub AreaEventHandler(ByVal area As Double) Handles oArea.ThreadCompleta
        MsgBox("A área do quadrado é " & area)
    End Sub

End Class