Imports System.Data.Sql
Imports System.Data.SqlClient

Module MODULOFILTRAR

    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Sub New()
        Try
            cn = New SqlConnection("Data Source=VALE\VALERIA;Initial catalog= TESIS ATLETISMO 2016; Integrated Security=True")
            cn.Open()

        Catch ex As Exception
            MessageBox.Show("error en la conexion: " + ex.ToString)
        End Try
    End Sub

    Sub filtrarporapellido(ByVal apellido As String, ByVal dgusuarios As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from usuario where apellido_usu like '" & apellido + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgusuarios.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("error al realizar el filtrado " + ex.ToString)
        End Try
    End Sub

    Sub filtrarapellidojuez(ByVal apellido As String, ByVal dgvjueces As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from juez where apellido_juez like '" & apellido + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgvjueces.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("error al realizar el filtrado " + ex.ToString)
        End Try
    End Sub

    Sub filtrarpordni(ByVal dni As String, ByVal dgvlistaatletas As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from atleta where dni like '" & dni + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgvlistaatletas.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("error al realizar el filtrado " + ex.ToString)
        End Try
    End Sub

    Sub filtrarnombreclub(ByVal nombreclub As String, ByVal dgvclubes As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from Club_Federación where nombre_club like '" & nombreclub + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgvclubes.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("error al realizar el filtrado " + ex.ToString)
        End Try
    End Sub

    Sub filtrarNombreCompetenciaCalle(ByVal nombreCompetenciaCalle As String, ByVal dgvCompetenciaCalle As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from Competencia where nombre_competencia like '" & nombreCompetenciaCalle + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgvCompetenciaCalle.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("error al realizar el filtrado " + ex.ToString)
        End Try
    End Sub

    Sub filtrarNombreCompetenciaAtleta(ByVal NombreCompetenciaAtleta As String, ByVal dgvAtletasxCompetencia As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from Atleta_Competencia inner join Competencia on Competencia.Id_Competencia = Atleta_Competencia.Id_Competencia where nombre_competencia like '" & NombreCompetenciaAtleta + "%" & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgvAtletasxCompetencia.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("error al realizar el filtrado " + ex.ToString)
        End Try
    End Sub
End Module
