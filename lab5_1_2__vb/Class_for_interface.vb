Imports System.Data.OleDb
Imports lab5_1_2__vb.Car
Imports lab5_1_2__vb




Public Class Class_for_interface : Implements Interface_for_lab_5_2


    Public CarArr As New List(Of Car)



    Public ReadOnly Property Кількість_елементів_масиву As Integer Implements Interface_for_lab_5_2.Кількість_елементів_масиву
        Get
            Return CarArr.Count
        End Get
    End Property







    Public ReadOnly Property Таблиця As DataTable Implements Interface_for_lab_5_2.Таблиця
        Get
            Dim MyTable As New DataTable
            Dim iRow As DataRow
            MyTable.Columns.Add("Second Name")
            MyTable.Columns.Add("Label")
            MyTable.Columns.Add("Number")
            MyTable.Columns.Add("Production Year")

            For Each element In CarArr
                iRow = MyTable.NewRow
                iRow("Second Name") = element.Second_Name
                iRow("Label") = element.Label
                iRow("Number") = element.Number
                iRow("Production Year") = element.Production_Year
                MyTable.Rows.Add(iRow)
            Next
            Return MyTable
        End Get
    End Property






    Public Sub Виведення_таблиці_у_файл(f As String) Implements Interface_for_lab_5_2.Виведення_таблиці_у_файл
        Dim rez As String
        rez = ""
        For i = 0 To CarArr.Count - 1
            rez += CarArr(i).Second_Name & " " &
                  CarArr(i).Label & " " &
                  CarArr(i).Number & " " &
                  CarArr(i).Production_Year & Environment.NewLine
        Next
        My.Computer.FileSystem.WriteAllText(f, rez, False)
    End Sub





    Public Sub Добавлення_елемента_з_форми_у_масив_структур(Name As String, v As Byte) Implements Interface_for_lab_5_2.Добавлення_елемента_з_форми_у_масив_структур
        Dim frmForm1 As New Form1()
        Form1.ShowDialog()

        CarArr.Add(Form1.new_Car)

    End Sub



    Public Sub Читання_таблиці_БД_у_масив_структур(f As String, t As String) Implements Interface_for_lab_5_2.Читання_таблиці_БД_у_масив_структур
        'Dim f As String = "E:\mathfuck\вба\db_for_vb.accdb"
        'Dim t As String = "tab1"
        Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & f)

        Try
            Dim CommandSQL As New OleDbCommand("Select * From " & t, con)
            Dim data As OleDbDataReader
            con.Open()
            data = CommandSQL.ExecuteReader
            While data.Read()
                CarArr.Add(New Car(data.Item(0), data.Item(1), data.Item(2), data.Item(3)))

            End While
            con.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub





    Public Function Отримання_елемента_з_масиву_структур(index As Byte) As String Implements Interface_for_lab_5_2.Отримання_елемента_з_масиву_структур
        Get_Elem.ShowDialog()

    End Function
End Class
