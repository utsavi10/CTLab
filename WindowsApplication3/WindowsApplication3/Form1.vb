Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_sybca_22140DataSet2.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter2.Fill(Me._sybca_22140DataSet2.student)
        'TODO: This line of code loads data into the '_sybca_22140DataSet1.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter1.Fill(Me._sybca_22140DataSet1.student)
        'TODO: This line of code loads data into the '_sybca_22140DataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me._sybca_22140DataSet.student)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.StudentTableAdapter.Fill(Me._sybca_22140DataSet.student)
    End Sub
End Class
