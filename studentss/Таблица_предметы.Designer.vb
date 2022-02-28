<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Таблица_предметы
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Таблица_предметы))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentsDataSet = New studentss.StudentsDataSet()
        Me.ПредметыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПредметыTableAdapter = New studentss.StudentsDataSetTableAdapters.ПредметыTableAdapter()
        Me.TableAdapterManager = New studentss.StudentsDataSetTableAdapters.TableAdapterManager()
        Me.ПредметыBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ПредметыBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.СоздатьToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ОткрытьToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.СохранитьToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ПечатьToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ВырезатьToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.КопироватьToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ВставкаToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.СправкаToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПредметыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПредметыBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ПредметыBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПредметыBindingSource, "Описание_предмета", True))
        Me.TextBox2.Location = New System.Drawing.Point(307, 173)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(207, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПредметыBindingSource, "Наименование_предмета", True))
        Me.TextBox1.Location = New System.Drawing.Point(307, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Описание предмета:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Наименование предмета:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Таблица ""Предметы"""
        '
        'StudentsDataSet
        '
        Me.StudentsDataSet.DataSetName = "StudentsDataSet"
        Me.StudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПредметыBindingSource
        '
        Me.ПредметыBindingSource.DataMember = "Предметы"
        Me.ПредметыBindingSource.DataSource = Me.StudentsDataSet
        '
        'ПредметыTableAdapter
        '
        Me.ПредметыTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = studentss.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ОценкиTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Me.ПредметыTableAdapter
        Me.TableAdapterManager.СпециальностиTableAdapter = Nothing
        Me.TableAdapterManager.СтудентыTableAdapter = Nothing
        '
        'ПредметыBindingNavigator
        '
        Me.ПредметыBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ПредметыBindingNavigator.BindingSource = Me.ПредметыBindingSource
        Me.ПредметыBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ПредметыBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ПредметыBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ПредметыBindingNavigatorSaveItem, Me.СоздатьToolStripButton, Me.ОткрытьToolStripButton, Me.СохранитьToolStripButton, Me.ПечатьToolStripButton, Me.toolStripSeparator, Me.ВырезатьToolStripButton, Me.КопироватьToolStripButton, Me.ВставкаToolStripButton, Me.toolStripSeparator1, Me.СправкаToolStripButton})
        Me.ПредметыBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ПредметыBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ПредметыBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ПредметыBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ПредметыBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ПредметыBindingNavigator.Name = "ПредметыBindingNavigator"
        Me.ПредметыBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ПредметыBindingNavigator.Size = New System.Drawing.Size(598, 25)
        Me.ПредметыBindingNavigator.TabIndex = 10
        Me.ПредметыBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 15)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'ПредметыBindingNavigatorSaveItem
        '
        Me.ПредметыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ПредметыBindingNavigatorSaveItem.Image = CType(resources.GetObject("ПредметыBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ПредметыBindingNavigatorSaveItem.Name = "ПредметыBindingNavigatorSaveItem"
        Me.ПредметыBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ПредметыBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'СоздатьToolStripButton
        '
        Me.СоздатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СоздатьToolStripButton.Image = CType(resources.GetObject("СоздатьToolStripButton.Image"), System.Drawing.Image)
        Me.СоздатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.СоздатьToolStripButton.Name = "СоздатьToolStripButton"
        Me.СоздатьToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.СоздатьToolStripButton.Text = "&Создать"
        '
        'ОткрытьToolStripButton
        '
        Me.ОткрытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ОткрытьToolStripButton.Image = CType(resources.GetObject("ОткрытьToolStripButton.Image"), System.Drawing.Image)
        Me.ОткрытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ОткрытьToolStripButton.Name = "ОткрытьToolStripButton"
        Me.ОткрытьToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ОткрытьToolStripButton.Text = "&Открыть"
        '
        'СохранитьToolStripButton
        '
        Me.СохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СохранитьToolStripButton.Image = CType(resources.GetObject("СохранитьToolStripButton.Image"), System.Drawing.Image)
        Me.СохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.СохранитьToolStripButton.Name = "СохранитьToolStripButton"
        Me.СохранитьToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.СохранитьToolStripButton.Text = "&Сохранить"
        '
        'ПечатьToolStripButton
        '
        Me.ПечатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ПечатьToolStripButton.Image = CType(resources.GetObject("ПечатьToolStripButton.Image"), System.Drawing.Image)
        Me.ПечатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ПечатьToolStripButton.Name = "ПечатьToolStripButton"
        Me.ПечатьToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ПечатьToolStripButton.Text = "&Печать"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ВырезатьToolStripButton
        '
        Me.ВырезатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ВырезатьToolStripButton.Image = CType(resources.GetObject("ВырезатьToolStripButton.Image"), System.Drawing.Image)
        Me.ВырезатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ВырезатьToolStripButton.Name = "ВырезатьToolStripButton"
        Me.ВырезатьToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ВырезатьToolStripButton.Text = "В&ырезать"
        '
        'КопироватьToolStripButton
        '
        Me.КопироватьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.КопироватьToolStripButton.Image = CType(resources.GetObject("КопироватьToolStripButton.Image"), System.Drawing.Image)
        Me.КопироватьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.КопироватьToolStripButton.Name = "КопироватьToolStripButton"
        Me.КопироватьToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.КопироватьToolStripButton.Text = "&Копировать"
        '
        'ВставкаToolStripButton
        '
        Me.ВставкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ВставкаToolStripButton.Image = CType(resources.GetObject("ВставкаToolStripButton.Image"), System.Drawing.Image)
        Me.ВставкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ВставкаToolStripButton.Name = "ВставкаToolStripButton"
        Me.ВставкаToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ВставкаToolStripButton.Text = "Вст&авка"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'СправкаToolStripButton
        '
        Me.СправкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СправкаToolStripButton.Image = CType(resources.GetObject("СправкаToolStripButton.Image"), System.Drawing.Image)
        Me.СправкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.СправкаToolStripButton.Name = "СправкаToolStripButton"
        Me.СправкаToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.СправкаToolStripButton.Text = "Спр&авка"
        '
        'Таблица_предметы
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 262)
        Me.Controls.Add(Me.ПредметыBindingNavigator)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Таблица_предметы"
        Me.Text = "Таблица_предметы"
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПредметыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПредметыBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ПредметыBindingNavigator.ResumeLayout(False)
        Me.ПредметыBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StudentsDataSet As StudentsDataSet
    Friend WithEvents ПредметыBindingSource As BindingSource
    Friend WithEvents ПредметыTableAdapter As StudentsDataSetTableAdapters.ПредметыTableAdapter
    Friend WithEvents TableAdapterManager As StudentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ПредметыBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ПредметыBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents СоздатьToolStripButton As ToolStripButton
    Friend WithEvents ОткрытьToolStripButton As ToolStripButton
    Friend WithEvents СохранитьToolStripButton As ToolStripButton
    Friend WithEvents ПечатьToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents ВырезатьToolStripButton As ToolStripButton
    Friend WithEvents КопироватьToolStripButton As ToolStripButton
    Friend WithEvents ВставкаToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents СправкаToolStripButton As ToolStripButton
End Class
