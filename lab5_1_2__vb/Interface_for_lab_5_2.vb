Public Interface Interface_for_lab_5_2
    Sub Виведення_таблиці_у_файл(ByVal f As String)
    Function Отримання_елемента_з_масиву_структур(ByVal index As Byte) As String
    Sub Читання_таблиці_БД_у_масив_структур(ByVal f As String, ByVal t As String) 'непарні варіанти
    'Sub Читання_записів_файла_у_масив_структур(ByVal f As String) 'парні варіанти
    Sub Добавлення_елемента_з_форми_у_масив_структур(ByVal Name As String, ByVal v As Byte)
    ReadOnly Property Кількість_елементів_масиву() As Integer
    ReadOnly Property Таблиця() As DataTable
End Interface
