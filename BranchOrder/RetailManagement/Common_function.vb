Imports System.Configuration

Module Common_function

    Public cnLclCon As New ADODB.Connection
    Public cnWebCon As New ADODB.Connection
    Public sLocalDBServerName As String
    Public sWebDBServerName As String
    Public sLocalDBUserID As String
    Public sWebDBUserID As String
    Public sLocalDBpwd As String
    Public sWebDBPwd As String
    Public sLocalDB As String
    Public sWebDB As String
    'Declares public variables...
    Public printer As String
    Public copies As Integer
    Friend TextToBePrinted As String 'Declares TextToBePrinted as a string.


    Public Sub OpenDBConnection()

        Try
            cnLclCon = New ADODB.Connection
            cnWebCon = New ADODB.Connection
            Dim m_sConnStr As String

            '"Data Source=ec2-52-200-94-144.compute-1.amazonaws.com\\SQLEXPRESS01;Database=Orderdb;User Id=SA;Password=Memory@123456"

            m_sConnStr = "Provider='SQLOLEDB';Data Source='" & sLocalDBServerName & "';Initial Catalog='" & sLocalDB & "';User Id='" & sLocalDBUserID & "';Password='" & sLocalDBpwd & "';"
            cnLclCon.Open(m_sConnStr)
            m_sConnStr = "Provider='SQLOLEDB';Data Source='" & sWebDBServerName & "';Initial Catalog='" & sWebDB & "';User Id='" & sWebDBUserID & "';Password='" & sWebDBPwd & "';"
            cnWebCon.Open(m_sConnStr)

        Catch er As Exception
            MsgBox(er.Message, vbInformation, "Unable to Connect Databases")

        End Try

    End Sub

    Public Sub ReadConfig()

        Dim appSettings = ConfigurationManager.AppSettings
        Try

            sLocalDBServerName = ""
            sWebDBServerName = ""
            sLocalDBUserID = ""
            sWebDBUserID = ""
            sLocalDBpwd = ""
            sWebDBPwd = ""
            sLocalDB = ""
            sWebDB = ""

            Dim reader As New System.Configuration.AppSettingsReader

            sLocalDBServerName = reader.GetValue("LocalDBServer", GetType(String))
            sWebDBServerName = reader.GetValue("WebDBServer", GetType(String))
            sLocalDBUserID = reader.GetValue("LocalDBUserName", GetType(String))
            sWebDBUserID = reader.GetValue("WebDBUserName", GetType(String))
            sLocalDBpwd = reader.GetValue("LocalDBPassword", GetType(String))
            sWebDBPwd = reader.GetValue("WebDBPassword", GetType(String))
            sLocalDB = reader.GetValue("LocalDB", GetType(String))
            sWebDB = reader.GetValue("WebDB", GetType(String))


        Catch er As Exception
            MsgBox(er.Message, vbInformation, "Unable to Read Config File")

        End Try
    End Sub

    Public Function Encode(Inp As String) As String
        Dim l, I, Q, R As Integer
        Dim C As String
        Dim Out As String = ""
        l = Len(Inp)
        For I = 1 To l
            C = Mid(Inp, I, 1)
            Q = Asc(C) / 2
            R = Asc(C) - (Q * 2)
            If R = 0 Then
                C = Chr(Asc(C) - 10)
            Else
                C = Chr(Asc(C) + 10)
            End If
            Out = Trim(Out) & C
        Next I
        Encode = Out

    End Function

    Public Function DCode(Inp As String) As String
        Dim l, I, Q, R As Integer
        Dim C As String
        Dim Out As String = ""
        l = Len(Inp)
        For I = 1 To l
            C = Mid(Inp, I, 1)
            Q = Asc(C) / 2
            R = Asc(C) - (Q * 2)
            If R = 0 Then
                C = Chr(Asc(C) + 10)
            Else
                C = Chr(Asc(C) - 10)
            End If
            Out = Trim(Out) & C
        Next I
        DCode = Out

    End Function
    Public Function GetBranchName(BranchID As Long) As String
        Dim RsBranch As New ADODB.Recordset
        RsBranch.Open("Select * from BranchMas", cnLclCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If RsBranch.EOF Then
            GetBranchName = "NotFound"
        Else
            GetBranchName = RsBranch.Fields("BranchName").Value
        End If

    End Function
End Module
