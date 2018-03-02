Public Class FInformeRegistros

    Private Sub FInformeRegistros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AY_MLATableAdapter.Fill(Me.AY1_001DataSet.AY_MLA)

    End Sub

    Private Sub DGVRegistrosTabla_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGVRegistrosTabla.DataError

        MessageBox.Show("Error de Lectura", "Error")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FIDisenoInforme.Show()

    End Sub

End Class
