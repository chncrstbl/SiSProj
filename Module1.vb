Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Module Module1

    Public Sub SetDefaultIcon(frm As Form)
        frm.Icon = New Icon("C:\Users\chris\source\repos\SiSProj\Resources\ico\PRISM_LOGO_512x512_NBG_WHITE_2-.ico")
    End Sub

    Public Sub SetRoundedCorners(control As Control, radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()


        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(control.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, control.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        control.Region = New Region(path)

    End Sub

    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader


    Sub connection()
        cn = New MySqlConnection
        cn.ConnectionString = "server=localhost; user id=root; password=; database=dbsisproj"
    End Sub
End Module
