﻿Public Class PrivateWindow
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim myUri As New Uri(ComboBox1.Text)
        Me.WebBrowser1.Navigate(myUri)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WebBrowser1.GoBack()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WebBrowser1.GoForward()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WebBrowser1.Refresh()
    End Sub
    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim myUri As New Uri(ComboBox1.Text)
            Me.WebBrowser1.Navigate(myUri)
        End If
    End Sub
End Class