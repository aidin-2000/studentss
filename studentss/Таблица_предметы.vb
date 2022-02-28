Public Class Таблица_предметы
    Private Sub ПредметыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ПредметыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub ПредметыBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ПредметыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ПредметыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Таблица_предметы_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentsDataSet.Предметы". При необходимости она может быть перемещена или удалена.
        Me.ПредметыTableAdapter.Fill(Me.StudentsDataSet.Предметы)

    End Sub
End Class