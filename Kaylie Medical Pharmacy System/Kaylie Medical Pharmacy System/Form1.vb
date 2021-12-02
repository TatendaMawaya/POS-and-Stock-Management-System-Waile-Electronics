Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AboutBox1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        LoginForm1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub PatientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PatientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PatientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PharmacyDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PharmacyDataSet.Drugs' table. You can move, or remove it, as needed.
        Me.DrugsTableAdapter.Fill(Me.PharmacyDataSet.Drugs)
        'TODO: This line of code loads data into the 'PharmacyDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.PharmacyDataSet.Employees)
        'TODO: This line of code loads data into the 'PharmacyDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.PharmacyDataSet.Patients)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        EmployeesBindingSource.MoveNext()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EmployeesBindingSource.MovePrevious()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        EmployeesBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        EmployeesBindingSource.AddNew()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        EmployeesBindingSource.EndEdit()
        EmployeesTableAdapter.Update(PharmacyDataSet.Employees)
        MsgBox("Successfully Saved")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DrugsBindingSource.MovePrevious()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DrugsBindingSource.MoveNext()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DrugsBindingSource.AddNew()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DrugsBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DrugsBindingSource.EndEdit()
        DrugsTableAdapter.Update(PharmacyDataSet.Drugs)

    End Sub
End Class
