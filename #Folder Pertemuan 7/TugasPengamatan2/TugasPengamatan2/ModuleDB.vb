Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI
Module ModuleDB
    Public pengguna As String = "mep"
    Public ppassword As String = "mep"
    Public myStrCon As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()
    Public myConn As MySqlConnection
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public myDataAdapter As MySqlDataAdapter
    Public jns As String = String.Empty
    Public tbluser As String = "users" 'nama tabel user
    Public bts As Integer = 5
    Public Sub CreateConnection()
        myStrCon.UserID = "root"
        myStrCon.Server = "127.0.0.1"
        myStrCon.Password = ""
        myStrCon.Database = "test" 'sesuaikan nama databasenya
        myStrCon.Port = 3307
        myConn = New MySqlConnection(myStrCon.ToString)
    End Sub

End Module
