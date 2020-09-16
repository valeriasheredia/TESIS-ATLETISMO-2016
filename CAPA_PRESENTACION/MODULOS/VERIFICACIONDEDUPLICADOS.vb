Imports System.Data.Sql
Imports System.Data.SqlClient

Module VERIFICACIONDEDUPLICADOS
    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader

    Sub New()
        Try
            cn = New SqlConnection("Data Source=VALE\VALERIA;Initial catalog= TESIS ATLETISMO 2016; Integrated Security=True")
            cn.Open()

        Catch ex As Exception
            MessageBox.Show("error en la conexion: " + ex.ToString)
        End Try
    End Sub

    ' RETORNA TRUE O FALSE SI EL REGISTRO EXISTE O NO EN LA BASE DE DATOS

    Function DniRegistrado(ByVal dniatleta As String) As Boolean
        Dim resultado As Boolean = False
        Try
            cmd = New SqlCommand("select * from atleta where Dni='" & dniatleta & "'", cn)

            Dr = cmd.ExecuteReader
            If dr.Read Then
                'NUEVOATLETA.txtDniAtleta.Text = dr(2).ToString
                resultado = True
            End If
            'dr.Close()
        Catch ex As Exception
            MsgBox("error en el procedimiento" + ex.ToString)
        End Try
        Return resultado
    End Function
End Module
