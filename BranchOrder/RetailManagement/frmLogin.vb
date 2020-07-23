Public Class frmLogin

    

    Private Sub frmLogin_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '  Dim E As Exception
        Try
            ReadConfig()
            OpenDBConnection()
        Catch er As Exception
            MsgBox(er.Message, vbInformation, "Unable to start")

        End Try

    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        End

    End Sub

    Private Sub cmdLogin_Click(sender As System.Object, e As System.EventArgs) Handles cmdLogin.Click
        Dim RsUsr As New ADODB.Recordset
        RsUsr.Open("Select * from  Admin where [UserName] ='" & txtUser.Text & "'", cnLclCon, ADODB.CursorTypeEnum.adOpenForwardOnly)

        If RsUsr.EOF Then
            MsgBox("User Id Not found")
            Exit Sub
        Else
            If Trim((RsUsr.Fields("password").Value.ToString)) = DCode(Trim(txtPassword.Text)) Then
                Me.Hide()
                FrmMain.Show()

            Else
                MsgBox("Wrong Password", MsgBoxStyle.Critical)
                Exit Sub

            End If
        End If
    End Sub

    Private Sub txtUser_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUser.TextChanged

    End Sub
End Class
