Public Class AddItem

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Please Enter Correct Information", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Try
            Dim TA As New POS.POSDataSetTableAdapters.ItemsTableAdapter
            TA.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
            status.Text = "One Item(s) Added"
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox1.Focus()

        Catch ex As Exception
            MsgBox("Barcode already Exist !", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        status.Text = ""
    End Sub

    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox2.MouseClick

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class