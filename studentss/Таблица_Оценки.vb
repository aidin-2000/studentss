Public Class Таблица_Оценки
    Private Sub ОценкиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ОценкиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Таблица_Оценки_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentsDataSet.Оценки". При необходимости она может быть перемещена или удалена.
        Me.ОценкиTableAdapter.Fill(Me.StudentsDataSet.Оценки)

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ОценкиBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ОценкиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ОценкиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox8.Text = ((Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox6.Text)) / 3)
    End Sub


End Class