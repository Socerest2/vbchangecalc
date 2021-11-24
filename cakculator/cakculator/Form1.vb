Public Class Form1
    Dim twenbil As Integer
    Dim tenbil As Integer
    Dim fivebil As Integer
    Dim onebil As Integer
    Dim qu As Integer
    Dim dime As Integer
    Dim nickle As Integer
    Dim changee As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        changee = change.Text
        'twenty
        twenbil = changee \ 2000
        changee -= twenbil * 2000
        twen.Text = twenbil
        'ten
        tenbil = changee \ 1000
        changee -= tenbil * 1000
        ten.Text = tenbil
        'five
        fivebil = changee \ 500
        changee -= fivebil * 500
        five.Text = fivebil
        'one
        onebil = changee \ 100
        changee -= onebil * 100
        one.Text = onebil
        'quarter
        qu = changee \ 25
        changee -= qu * 25
        quart.Text = qu
        'dime
        dime = changee \ 10
        changee -= dime * 10
        tenc.Text = dime
        'nickle
        nickle = changee \ 5
        changee -= nickle * 5
        nick.Text = nickle
        'penny
        penny.Text = changee

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        twen.Text = Nothing
        ten.Text = Nothing
        five.Text = Nothing
        one.Text = Nothing
        quart.Text = Nothing
        tenc.Text = Nothing
        nick.Text = Nothing
        penny.Text = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
