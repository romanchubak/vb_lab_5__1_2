Public Class Form
    Public ob As New Class_for_interface

    Private Sub brnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ob.Добавлення_елемента_з_форми_у_масив_структур("s", 0)
    End Sub

    Private Sub btn_read_from_db_Click(sender As Object, e As EventArgs) Handles btn_read_from_db.Click
        ob.Читання_таблиці_БД_у_масив_структур("E:\mathfuck\вба\db_for_vb.accdb", "tab1")
    End Sub

    Private Sub btn_write_to_file_Click(sender As Object, e As EventArgs) Handles btn_write_to_file.Click
        ob.Виведення_таблиці_у_файл("file.txt")
    End Sub

    Private Sub btn_show_all_arr_Click(sender As Object, e As EventArgs) Handles btn_show_all_arr.Click
        DataGridViewNew.DataSource = ob.Таблиця
    End Sub

    Private Sub btn_get_elem_from_arr_Click(sender As Object, e As EventArgs) Handles btn_get_elem_from_arr.Click
        ob.Отримання_елемента_з_масиву_структур(0)
    End Sub
End Class