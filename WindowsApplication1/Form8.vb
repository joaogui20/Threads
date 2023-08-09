Imports System.Threading
Imports System.Drawing.Imaging

Public Class Form8
    Private rb As Random
    Private thread, thread2, thread3, thread4, thread5, thread6 As Thread

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb = New Random
    End Sub

    Private Sub btnThread1_Click(sender As Object, e As EventArgs) Handles btnThread1.Click
        thread = New Thread(Sub(r)
                                For i = 0 To 100

                                    Dim widht As Integer = rb.Next(0, Me.Width)
                                    Dim height As Integer = rb.Next(50, Me.Height)

                                    Me.CreateGraphics().DrawEllipse(New Pen(Brushes.Red, 1), New Rectangle(widht, height, 10, 10))

                                    System.Threading.Thread.Sleep(100)

                                Next
                                MessageBox.Show("Thread finalizada")
                            End Sub) With {
                            .IsBackground = True}
        thread.Start()
    End Sub

    Private Sub btnThread2_Click(sender As Object, e As EventArgs) Handles btnThread2.Click
        thread2 = New Thread(Sub(r)
                                 For i = 0 To 100

                                     Dim widht As Integer = rb.Next(0, Me.Width)
                                     Dim height As Integer = rb.Next(50, Me.Height)

                                     Me.CreateGraphics().DrawEllipse(New Pen(Brushes.Aqua, 1), New Rectangle(widht, height, 10, 10))

                                     System.Threading.Thread.Sleep(100)
                                 Next
                                 MessageBox.Show("Thread 2 finalizada")
                             End Sub) With {
                            .IsBackground = True}
        thread2.Start()
    End Sub

    Private Sub btnThread3_Click(sender As Object, e As EventArgs) Handles btnThread3.Click
        thread3 = New Thread(Sub(r)
                                 For i = 0 To 100

                                     Dim widht As Integer = rb.Next(0, Me.Width)
                                     Dim height As Integer = rb.Next(50, Me.Height)

                                     Me.CreateGraphics().DrawEllipse(New Pen(Brushes.Black, 1), New Rectangle(widht, height, 10, 10))

                                     System.Threading.Thread.Sleep(100)
                                 Next
                                 MessageBox.Show("Thread 3 finalizada")
                             End Sub) With {
                            .IsBackground = True}
        thread3.Start()
    End Sub

    Private Sub btnThread4_Click(sender As Object, e As EventArgs) Handles btnThread4.Click
        thread4 = New Thread(Sub(r)
                                 For i = 0 To 100

                                     Dim widht As Integer = rb.Next(0, Me.Width)
                                     Dim height As Integer = rb.Next(50, Me.Height)

                                     Me.CreateGraphics().DrawEllipse(New Pen(Brushes.DarkGreen, 1), New Rectangle(widht, height, 10, 10))

                                     System.Threading.Thread.Sleep(100)
                                 Next
                                 MessageBox.Show("Thread 4 finalizada")
                             End Sub) With {
                            .IsBackground = True}
        thread4.Start()
    End Sub

    Private Sub btnThread5_Click(sender As Object, e As EventArgs) Handles btnThread5.Click
        thread5 = New Thread(Sub(r)
                                 For i = 0 To 100

                                     Dim widht As Integer = rb.Next(0, Me.Width)
                                     Dim height As Integer = rb.Next(50, Me.Height)

                                     Me.CreateGraphics().DrawEllipse(New Pen(Brushes.DarkViolet, 1), New Rectangle(widht, height, 10, 10))

                                     System.Threading.Thread.Sleep(100)
                                 Next
                                 MessageBox.Show("Thread 5 finalizada")
                             End Sub) With {
                            .IsBackground = True}
        thread5.Start()
    End Sub

    Private Sub btnThread6_Click(sender As Object, e As EventArgs) Handles btnThread6.Click
        thread6 = New Thread(Sub(r)
                                 For i = 0 To 100

                                     Dim widht As Integer = rb.Next(0, Me.Width)
                                     Dim height As Integer = rb.Next(50, Me.Height)

                                     Me.CreateGraphics().DrawEllipse(New Pen(Brushes.Magenta, 1), New Rectangle(widht, height, 10, 10))

                                     System.Threading.Thread.Sleep(100)
                                 Next
                                 MessageBox.Show("Thread 6 finalizada")
                             End Sub) With {
                            .IsBackground = True}
        thread6.Start()
    End Sub
End Class
