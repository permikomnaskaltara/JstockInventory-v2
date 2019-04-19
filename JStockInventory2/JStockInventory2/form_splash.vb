Imports JStockInventory2.form_login
Imports System
Imports System.IO
Public Class form_splash
    Public data_obj As New data_object
    Public basic_op As New basic_op

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            form_login.Show()
            basic_op.setfokus(form_login)
            Me.Hide()
            'form_login.Show()
            Timer1.Enabled = False
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub form_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            data_obj._set_init_db_str()
            basic_op.jstock_app_path = basic_op.jstock_read_config()

            Dim cur_drive = ret_current_drive_letter()
            Dim file1 = cur_drive & "\xampp\xampp_start.exe"
            If (File.Exists(file1)) Then
                'Process.Start(cur_drive & "\xampp\xampp_start.exe")
                Dim startInfo As New ProcessStartInfo(cur_drive & "\xampp\xampp_start.exe")
                startInfo.WindowStyle = ProcessWindowStyle.Hidden

                Process.Start(startInfo)


            End If
            basic_op.setfokus(Me)
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Public Function ret_current_drive_letter()
        Dim methodName As String = System.Reflection.MethodBase.GetCurrentMethod().Name
        Try
            Dim current_drive = ""
            Dim env = Environment.GetEnvironmentVariable("windir")
            current_drive = Path.GetPathRoot(env)
            Return current_drive
        Catch ex As Exception
            Console.WriteLine(methodName)
            Console.WriteLine(ex.ToString)
            Return "c:\"
        End Try
    End Function


End Class