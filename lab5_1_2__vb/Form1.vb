Public Class Form1

    Private Sub txtSecond_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecond_name.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        'e.KeyChar = e.KeyChar.ToString.ToUpper
        If Not (e.KeyChar Like "[A-Za-zА-Яа-яїієЇІЄ’]") Then
            e.Handled = True
            Beep()
        End If
    End Sub
    Private Sub txtSecond_name_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSecond_name.Validating

        Dim count As Integer, count2 As Integer
        For Each i As String In txtSecond_name.Text

            If (i Like "[А-Яа-яії'ЇІЯ]") Then
                count = count + 1
            End If
        Next
        For Each i As String In txtSecond_name.Text
            If (i Like "[A-Za-z]") Then
                count2 = count2 + 1
            End If
        Next


        If (count < txtSecond_name.Text.Length And count2 < txtSecond_name.Text.Length) Then
            e.Cancel = True
            MsgBox("Введіть правильно Прізвище")
        End If

    End Sub
    Private Sub txtLabel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLabel.KeyPress
            If e.KeyChar = vbBack Then Exit Sub
        'e.KeyChar = e.KeyChar.ToString.ToUpper
        If Not (e.KeyChar Like "[A-Za-z]") Then
            e.Handled = True
            Beep()
        End If
    End Sub

        Private Sub txtNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumber.Validating
            If Not (txtNumber.Text Like "[А-Я][А-Я] [0-9][0-9][0-9][0-9] [А-Я][А-Я]") Then
                e.Cancel = True
                MsgBox("Введіть правильний номер авто")
            End If

        End Sub

    Private Sub txtProdaction_Year_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtProdaction_Year.Validating
        If Not (txtProdaction_Year.Text <> "") Then
        ElseIf Not (txtProdaction_Year.Text Like "####" And Convert.ToInt32(txtProdaction_Year.Text) > 1904) Then
            e.Cancel = True
            MsgBox("Введіть правильний рік випуску")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLabel.Text = ""
        txtNumber.Text = ""
        txtProdaction_Year.Text = ""
        txtSecond_name.Text = ""
    End Sub
    Public new_Car As New Car

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        new_Car.Number = txtNumber.Text
        new_Car.Label = txtLabel.Text
        new_Car.Production_Year = txtProdaction_Year.Text
        new_Car.Second_Name = txtSecond_name.Text

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Dim txt As Control
        For Each txt In Controls
            If TypeOf txt Is TextBox Then
                If txt.Text.Trim = String.Empty Then
                    btnEnter.Enabled = False
                    Exit Sub
                End If
            End If
        Next
        btnEnter.Enabled = True
    End Sub

End Class