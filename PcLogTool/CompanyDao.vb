﻿'mysqlを使う
Imports MySql.Data.MySqlClient

Friend Class CompanyDao

    '    Dim Con As New MySqlConnection
    Dim Con As MySqlConnection
    Dim result As String
    Dim resultArray As New ArrayList
    Dim dr As MySqlDataReader

    '    Private MysqlManage

    Public Sub New(oCon)
        Dim Con As New MySqlConnection
        Con.ConnectionString = MysqlManage.Connect()
        Con.Open()
        Con.ConnectionString = MysqlManage.Connect()
    End Sub

    Public Function GetAll()

        '        Con.ConnectionString = MysqlManage.Connect()

        Dim cmd As MySqlCommand

        Dim sqlStr As String

        '接続 
        Con.Open()
        'SQL文 
        sqlStr = "SELECT id,company_name FROM company"

        'MySQLCommand作成 
        cmd = New MySqlCommand(sqlStr, Con)

        'SQL文実行 
        dr = cmd.ExecuteReader

        Return dr

    End Function

    '企業名取得関数
    Public Function getCompanyInfo()
        '        Dim Con As New MySqlConnection
        Dim dr As MySqlDataReader
        Dim resultArray As Hashtable = New Hashtable

        Try
            '           Con.ConnectionString = MysqlManage.Connect()

            Dim cmd As MySqlCommand

            Dim sqlStr As String

            '接続 
            Dim Con As New MySqlConnection
            Con.ConnectionString = MysqlManage.Connect()
            Con.Open()
            'SQL文 
            sqlStr = "SELECT id,company_name FROM company"

            'MySQLCommand作成 
            cmd = New MySqlCommand(sqlStr, Con)

            'SQL文実行 
            dr = cmd.ExecuteReader

            Return dr

        Catch ex As Exception
            MsgBox("getComapnyNameでエラー")
        Finally

            'クローズ 
            Con.Close()
        End Try

        Return resultArray

    End Function
End Class
