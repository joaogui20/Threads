Imports System.Threading

Public Class Form1

    Private t1, t2, t3 As Thread

    Public Sub prenchelista1()
        Dim j As Integer = 1
        While True
            lstContagem1.Items.Add(" Thread 1 # " & CStr(j))
            j += 1
            Thread.Sleep(1000)
        End While
    End Sub

    Public Sub prenchelista2()
        Dim k As Integer = 1
        While True
            lstContagem2.Items.Add(" Thread 2 # " & CStr(k))
            k += 1
            Thread.Sleep(2000)
        End While
    End Sub

    Public Sub prenchelista3()
        Dim m As Integer = 1
        While True
            lstContagem3.Items.Add(" Thread 3 # " & CStr(m))
            m += 1
            If m = 10 Then
                lstContagem3.Items.Add(" interrompi a thread...")
                Thread.Sleep(Timeout.Infinite)
            End If
        End While
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub btnThread_Click(sender As Object, e As EventArgs) Handles btnThread.Click
        t1 = New Thread(AddressOf Me.prenchelista1)
        t1.Start()
    End Sub

    Private Sub btnParada1_Click(sender As Object, e As EventArgs) Handles btnParada1.Click
        t1.Abort()
    End Sub

    Private Sub btnThread2_Click(sender As Object, e As EventArgs) Handles btnThread2.Click
        t2 = New Thread(AddressOf Me.prenchelista2)
        t2.Start()
    End Sub

    Private Sub btnParar2_Click(sender As Object, e As EventArgs) Handles btnParar2.Click
        t2.Abort()
    End Sub

    Private Sub btnSuspender_Click(sender As Object, e As EventArgs) Handles btnSuspender.Click
        t2.Suspend()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        t2.Resume()
    End Sub

    Private Sub btnThread3_Click(sender As Object, e As EventArgs) Handles btnThread3.Click
        t3 = New Thread(AddressOf Me.prenchelista3)
        t3.Start()
    End Sub

    Private Sub btnParar3_Click(sender As Object, e As EventArgs) Handles btnParar3.Click
        t3.Abort()
    End Sub
End Class
