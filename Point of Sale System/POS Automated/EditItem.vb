Public Class EditItem

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Please Enter Correct Information", MsgBoxStyle.Critical)
                Exit Sub
            End If
            BindingSource1.EndEdit()
            ItemsTA.Update(Me.POSDataSet.Items)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub FillInfo(ByVal Barcode As String)
        Dim TA As New POS.POSDataSetTableAdapters.ItemsTableAdapter
        TA.FillByBarcode(POSDataSet.Items, Barcode)
    End Sub
    Private Sub EditItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
End Class