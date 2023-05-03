Public Class frmcliente
    Private dt As New DataTable

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fcliente
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False

        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(ds.Tables(0))
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False 
                datalistado.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False

    End Sub
End Class