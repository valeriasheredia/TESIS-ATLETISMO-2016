Imports CAPA_DATOS
Imports CAPA_ENTIDAD

Public Class CNCompetencias

    Dim objcompetencia As New DAOCompetencias
    'PABLOOO
    Dim objcompetencia1 As New DAOVarios

    Public Function ListadoTodasCompetencias() As DataSet
        Return objcompetencia.ListadoTodasCompetencias
    End Function

    Public Function ListaCompetenciaCalle() As DataSet
        Return objcompetencia.ListaCompetenciaCalle
    End Function

    Public Function ListaCompetenciaPista() As DataSet
        Return objcompetencia.ListaCompetenciaPista
    End Function

    Public Function UltimaCompetencia() As DataSet
        Return objcompetencia.UltimaCompetencia
    End Function

    'Public Sub BuscarCompetenciaporId(ByVal codigo As Integer)
    '    objcompetencia.BuscarCompetenciaporId(codigo)
    'End Sub

    ' hizo el profe

    Public Function ListadoTodasCompetencias(id_competencia As Integer) As DataTable
        Return objcompetencia.ListadoTodasCompetencias(id_competencia)
    End Function

    Public Function nuevoCodigoCompetencia() As String
        Return objcompetencia.nuevoCodigoCompetencia
    End Function

    Public Function ListaLocalidadCompetencia() As DataSet
        Return objcompetencia.ListaLocalidadCompetencia
    End Function

    Public Function ListaLocalidadCompetencia(Id_Provincia As Integer) As DataSet
        Return objcompetencia.ListaLocalidadCompetencia(Id_Provincia)
    End Function

    Public Function ListaProvinciaCompetencias() As DataSet
        Return objcompetencia.ListaProvinciaCompetencias
    End Function

    Public Function ListaCalle() As DataSet
        Return objcompetencia.ListaCalle
    End Function

    Public Function ListaUsuariosCompetencia() As DataSet
        Return objcompetencia.ListaUsuariosCompetencia
    End Function

    Public Function Disciplinas() As DataSet
        Return objcompetencia.Disciplinas
    End Function

    Public Function Pruebas_x_Disciplina(Id_Disciplina As Integer) As DataSet
        Return objcompetencia.Pruebas_x_Disciplina(Id_Disciplina)
    End Function

    Public Function Pruebas() As DataSet
        Return objcompetencia.Pruebas
    End Function

    Public Sub NuevaCompetencia(ByVal ObjCom As CECompetencias)
        objcompetencia.NuevaCompetencia(ObjCom)
        ' MsgBox("Se generó la competencia " & ObjCom.id_competencia)
    End Sub

    'Public Function Sexoatleta() As DataSet
    '    Return objcompetencia.Sexoatleta
    'End Function

    Public Sub ActualizarCompetencia(ByVal competencia As CECompetencias)
        objcompetencia.ActualizarCompetencia(competencia.id_competencia,
                                 competencia.Nombre_competencia,
                                 competencia.lugar_competencia,
                                 competencia.distancia,
                                 competencia.fecha_inicio,
                                 competencia.hora_inicio,
                                 competencia.id_provincia,
                                 competencia.id_localidad,
                                 competencia.id_disciplina,
                                 competencia.id_prueba,
                                 competencia.otra,
                                 competencia.juez1,
                                 competencia.juez2,
                                 competencia.juez3,
                                 competencia.id_usuario,
                                 competencia.Estado_Competencia)
    End Sub

    Public Sub eliminarCompetencia(ByVal id As Integer)
        objcompetencia.eliminarCompetencia(id)
    End Sub

    'este  metodo devuelve un vector con los objetos del tipo Competencia
    Public Function ListadoDeCompetenciasDTO() As List(Of CECompetencias)
        Return objcompetencia.ListadoDeCompetenciasDTO()
    End Function

    Public Function ListadoCompetenciaCalleDTO() As List(Of CECompetencias)
        Return objcompetencia.ListadoCompetenciaCalleDTO()
    End Function

    Public Function ListadoCompetenciaPistaDTO() As List(Of CECompetencias)
        Return objcompetencia.ListadoCompetenciaPistaDTO()
    End Function

    'usamos LINQ para hacer las conusltas
    Public Function ListaCompetenciaCalleDTO() As List(Of CECompetencias)
        Dim objetoCOmpetenciaListdoSINFiltrar As New List(Of CECompetencias)
        objetoCOmpetenciaListdoSINFiltrar = ListadoDeCompetenciasDTO()
        Return objetoCOmpetenciaListdoSINFiltrar.Where(Function(objeto) objeto.distancia <> 0).ToList()
    End Function

    Public Function ListaCompetenciaPistaDTO() As List(Of CECompetencias)
        Dim objetoCOmpetenciaListdoSINFiltrar As New List(Of CECompetencias)
        objetoCOmpetenciaListdoSINFiltrar = ListadoDeCompetenciasDTO()
        ' objetoCOmpetenciaListdoSINFiltrar.First(Function(objej) objej.id_competencia = 3)
        Return objetoCOmpetenciaListdoSINFiltrar.Where(Function(objeto) objeto.distancia <> 0).ToList()
    End Function

    Public Function JuezPrincipal1() As DataSet
        Return objcompetencia.JuezPrincipal1
    End Function

    Public Function JuezPrincipal2() As DataSet
        Return objcompetencia.JuezPrincipal2
    End Function

    Public Function JuezPrincipal3() As DataSet
        Return objcompetencia.JuezPrincipal3
    End Function

    Public Function UsuarioPrincipal() As DataSet
        Return objcompetencia.UsuarioPrincipal
    End Function

    'PABLOOOOO
    Public Function BuscarCompetenciaporId(ByVal codigo As Integer)
        Return objcompetencia1.BuscarCopmPorId(codigo)
    End Function
End Class
