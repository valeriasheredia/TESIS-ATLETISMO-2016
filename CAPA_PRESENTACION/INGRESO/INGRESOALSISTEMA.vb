Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD


Public Class INGRESOALSISTEMA

    Private Sub INGRESOALSISTEMA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Dim capanegocio As New CNIngreso


    Private Sub btningresar_Click(sender As System.Object, e As System.EventArgs) Handles btningresar.Click

        Try
            If usuarioRegistrado(txtnombreusuario.Text) = True Then
                Dim contra As String = contraseña(txtnombreusuario.Text)
                If contra.Equals(txtcontraseña.Text) = True Then
                    VentanaPrincipaldelSistema.ShowDialog()
                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Exclamation, "Atención")
                End If
            Else
                MsgBox("El Usuario: " + txtnombreusuario.Text + " no se encuentra registrado", MsgBoxStyle.Exclamation, "Atención")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btncancelar_Click(sender As System.Object, e As System.EventArgs) Handles btncancelar.Click
        If MsgBox("desea salir del programa...?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Close()
        End If
    End Sub

    'Private Sub btningresar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles btningresar.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        txtcontraseña.text = asc(e.keychar)

    '    End If
    'End Sub
End Class