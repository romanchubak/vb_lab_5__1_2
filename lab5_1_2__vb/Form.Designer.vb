<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridViewNew = New System.Windows.Forms.DataGridView()
        Me.btn_read_from_db = New System.Windows.Forms.Button()
        Me.btn_write_to_file = New System.Windows.Forms.Button()
        Me.btn_show_all_arr = New System.Windows.Forms.Button()
        Me.btn_get_elem_from_arr = New System.Windows.Forms.Button()
        CType(Me.DataGridViewNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(562, 235)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(145, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Elem to Array"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridViewNew
        '
        Me.DataGridViewNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewNew.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewNew.Name = "DataGridViewNew"
        Me.DataGridViewNew.Size = New System.Drawing.Size(445, 319)
        Me.DataGridViewNew.TabIndex = 1
        '
        'btn_read_from_db
        '
        Me.btn_read_from_db.Location = New System.Drawing.Point(562, 70)
        Me.btn_read_from_db.Name = "btn_read_from_db"
        Me.btn_read_from_db.Size = New System.Drawing.Size(145, 23)
        Me.btn_read_from_db.TabIndex = 3
        Me.btn_read_from_db.Text = "Read from DB"
        Me.btn_read_from_db.UseVisualStyleBackColor = True
        '
        'btn_write_to_file
        '
        Me.btn_write_to_file.Location = New System.Drawing.Point(562, 109)
        Me.btn_write_to_file.Name = "btn_write_to_file"
        Me.btn_write_to_file.Size = New System.Drawing.Size(145, 23)
        Me.btn_write_to_file.TabIndex = 4
        Me.btn_write_to_file.Text = "Write to File"
        Me.btn_write_to_file.UseVisualStyleBackColor = True
        '
        'btn_show_all_arr
        '
        Me.btn_show_all_arr.Location = New System.Drawing.Point(562, 151)
        Me.btn_show_all_arr.Name = "btn_show_all_arr"
        Me.btn_show_all_arr.Size = New System.Drawing.Size(145, 23)
        Me.btn_show_all_arr.TabIndex = 5
        Me.btn_show_all_arr.Text = "Show all Array"
        Me.btn_show_all_arr.UseVisualStyleBackColor = True
        '
        'btn_get_elem_from_arr
        '
        Me.btn_get_elem_from_arr.Location = New System.Drawing.Point(562, 196)
        Me.btn_get_elem_from_arr.Name = "btn_get_elem_from_arr"
        Me.btn_get_elem_from_arr.Size = New System.Drawing.Size(145, 23)
        Me.btn_get_elem_from_arr.TabIndex = 6
        Me.btn_get_elem_from_arr.Text = "Get Elem from Array"
        Me.btn_get_elem_from_arr.UseVisualStyleBackColor = True
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 343)
        Me.Controls.Add(Me.btn_get_elem_from_arr)
        Me.Controls.Add(Me.btn_show_all_arr)
        Me.Controls.Add(Me.btn_write_to_file)
        Me.Controls.Add(Me.btn_read_from_db)
        Me.Controls.Add(Me.DataGridViewNew)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridViewNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridViewNew As DataGridView
    Friend WithEvents btn_read_from_db As Button
    Friend WithEvents btn_write_to_file As Button
    Friend WithEvents btn_show_all_arr As Button
    Friend WithEvents btn_get_elem_from_arr As Button
End Class
