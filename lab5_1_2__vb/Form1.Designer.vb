<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtProdaction_Year = New System.Windows.Forms.TextBox()
        Me.txtLabel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSecond_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(283, 173)
        Me.txtNumber.MaxLength = 10
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 19
        '
        'txtProdaction_Year
        '
        Me.txtProdaction_Year.Location = New System.Drawing.Point(283, 124)
        Me.txtProdaction_Year.MaxLength = 4
        Me.txtProdaction_Year.Name = "txtProdaction_Year"
        Me.txtProdaction_Year.Size = New System.Drawing.Size(100, 20)
        Me.txtProdaction_Year.TabIndex = 18
        '
        'txtLabel
        '
        Me.txtLabel.Location = New System.Drawing.Point(234, 76)
        Me.txtLabel.MaxLength = 100
        Me.txtLabel.Name = "txtLabel"
        Me.txtLabel.Size = New System.Drawing.Size(149, 20)
        Me.txtLabel.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Номер авто"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Марка авто"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Рік випуску"
        '
        'txtSecond_name
        '
        Me.txtSecond_name.Location = New System.Drawing.Point(234, 28)
        Me.txtSecond_name.MaxLength = 50
        Me.txtSecond_name.Name = "txtSecond_name"
        Me.txtSecond_name.Size = New System.Drawing.Size(149, 20)
        Me.txtSecond_name.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Прізвище"
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(87, 280)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Очистка полів"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEnter.Location = New System.Drawing.Point(283, 280)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(121, 23)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "Ввід даних"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtProdaction_Year)
        Me.Controls.Add(Me.txtLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSecond_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Анкета"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtProdaction_Year As TextBox
    Friend WithEvents txtLabel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecond_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEnter As Button
End Class
