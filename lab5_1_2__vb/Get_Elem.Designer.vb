<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Get_Elem
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView_for_get_elem = New System.Windows.Forms.DataGridView()
        Me.txt_seach_Label = New System.Windows.Forms.TextBox()
        Me.lbl_input_Label = New System.Windows.Forms.Label()
        Me.btn_ok_for_seach_label = New System.Windows.Forms.Button()
        CType(Me.DataGridView_for_get_elem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_for_get_elem
        '
        Me.DataGridView_for_get_elem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_for_get_elem.Location = New System.Drawing.Point(12, 110)
        Me.DataGridView_for_get_elem.Name = "DataGridView_for_get_elem"
        Me.DataGridView_for_get_elem.Size = New System.Drawing.Size(451, 150)
        Me.DataGridView_for_get_elem.TabIndex = 0
        '
        'txt_seach_Label
        '
        Me.txt_seach_Label.Location = New System.Drawing.Point(231, 12)
        Me.txt_seach_Label.Name = "txt_seach_Label"
        Me.txt_seach_Label.Size = New System.Drawing.Size(202, 20)
        Me.txt_seach_Label.TabIndex = 1
        '
        'lbl_input_Label
        '
        Me.lbl_input_Label.AutoSize = True
        Me.lbl_input_Label.Location = New System.Drawing.Point(39, 15)
        Me.lbl_input_Label.Name = "lbl_input_Label"
        Me.lbl_input_Label.Size = New System.Drawing.Size(105, 13)
        Me.lbl_input_Label.TabIndex = 2
        Me.lbl_input_Label.Text = "Введіть марку авто"
        '
        'btn_ok_for_seach_label
        '
        Me.btn_ok_for_seach_label.Location = New System.Drawing.Point(155, 65)
        Me.btn_ok_for_seach_label.Name = "btn_ok_for_seach_label"
        Me.btn_ok_for_seach_label.Size = New System.Drawing.Size(168, 23)
        Me.btn_ok_for_seach_label.TabIndex = 3
        Me.btn_ok_for_seach_label.Text = "Вивести список "
        Me.btn_ok_for_seach_label.UseVisualStyleBackColor = True
        '
        'Get_Elem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 272)
        Me.Controls.Add(Me.btn_ok_for_seach_label)
        Me.Controls.Add(Me.lbl_input_Label)
        Me.Controls.Add(Me.txt_seach_Label)
        Me.Controls.Add(Me.DataGridView_for_get_elem)
        Me.Name = "Get_Elem"
        Me.Text = "Get_Elem"
        CType(Me.DataGridView_for_get_elem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_for_get_elem As DataGridView
    Friend WithEvents txt_seach_Label As TextBox
    Friend WithEvents lbl_input_Label As Label
    Friend WithEvents btn_ok_for_seach_label As Button
End Class
