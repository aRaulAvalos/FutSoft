﻿Public Class FormRegistroJugadoresEquipo

    Private Sub LabJugadores_Click(sender As Object, e As EventArgs) Handles LabJugadores.Click
        FormReguistrosJugadores.Show()
        Me.Hide()
    End Sub

    Private Sub LabCerrarSecion_Click(sender As Object, e As EventArgs) Handles LabAtras.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormReguistrosJugadores.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FormRegistroEquipo.Show()
        Me.Hide()
    End Sub

    Private Sub LabEquipos_Click(sender As Object, e As EventArgs) Handles LabEquipos.Click
        FormRegistroEquipo.Show()
        Me.Hide()
    End Sub
End Class