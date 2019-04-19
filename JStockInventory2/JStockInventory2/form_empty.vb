Imports MySql.Data.MySqlClient
Imports System.Math
Imports System
Imports System.Text
Imports System.Environment
Public Class form_empty
    Public data_obj As New data_object
    Public basic_op As New basic_op

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim hapus = basic_op.konfirmasi_hapus("Apakah yakin seluruh isi database akan dikosongkan ?", "Kosongkan Seluruh Isi Database")
            If hapus = 1 Then
                data_obj.mysql_truncate("master_customer")
                data_obj.mysql_truncate("master_gudang")
                data_obj.mysql_truncate("master_kategori_produk")
                data_obj.mysql_truncate("master_supplier")
                data_obj.mysql_truncate("op_histori_kas")
                data_obj.mysql_truncate("op_histori_kas_flow")
                data_obj.mysql_truncate("op_stok")
                data_obj.mysql_truncate("op_stok_adjustment")
                data_obj.mysql_truncate("op_stok_keluar")
                data_obj.mysql_truncate("op_stok_masuk")
                data_obj.mysql_truncate("master_merek")
                MsgBox("Seluruh data dummy telah dikosongkan !")
            End If
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Class