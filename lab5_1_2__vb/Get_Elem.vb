Public Class Get_Elem
    Private Sub btn_ok_for_seach_label_Click(sender As Object, e As EventArgs) Handles btn_ok_for_seach_label.Click
        If txt_seach_Label.Text <> "" Then
            Dim MyTable As New DataTable
            Dim iRow As DataRow
            MyTable.Columns.Add("Second Name")
            MyTable.Columns.Add("Label")
            MyTable.Columns.Add("Number")
            MyTable.Columns.Add("Production Year")

            For Each element In Form.ob.CarArr
                If element.Label = txt_seach_Label.Text Then
                    iRow = MyTable.NewRow
                    iRow("Second Name") = element.Second_Name
                    iRow("Label") = element.Label
                    iRow("Number") = element.Number
                    iRow("Production Year") = element.Production_Year
                    MyTable.Rows.Add(iRow)
                End If
            Next
            DataGridView_for_get_elem.DataSource = MyTable
        End If

    End Sub
End Class