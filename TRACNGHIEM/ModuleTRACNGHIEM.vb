Imports System.Data.SqlClient

Module ModuleTRACNGHIEM
    Public conn As New SqlConnection
    Public ConnStr As String
    Public Function KetNoi() As Int32
        If conn.State = ConnectionState.Open Then conn.Close()
        Try

            ConnStr = "Data Source=PC;Initial Catalog=TRAC_NGHIEM;User ID=sa;Password=tram"
            conn.ConnectionString = ConnStr
            conn.Open()
            KetNoi = 1
        Catch ex As Exception
            MsgBox("Lỗi kết nối cơ sở dữ liệu . " & vbCrLf & _
               "Bạn xem lại hàm KetNoi ")
            KetNoi = 0
        End Try
    End Function

#Region "Bẫy ký số nhập"
    Public Function NhapkySo(ByVal kytu As Char) As Boolean
        NhapkySo = False
        If kytu = Chr(13) Then
            My.Computer.Keyboard.SendKeys("{TAB}", False)
            Exit Function
        End If
        If Asc(kytu) >= 26 Then
            Dim str As String
            str = "0123456789"
            If InStr(str, kytu) <> 0 Then NhapkySo = True
        End If

    End Function
    Public Function NhapkySo_vachamphay(ByVal kytu As Char) As Boolean
        NhapkySo_vachamphay = False
        If kytu = Chr(13) Then
            My.Computer.Keyboard.SendKeys("{TAB}", False)
            Exit Function
        End If
        If Asc(kytu) >= 26 Then
            Dim str As String
            str = "0123456789; "
            If InStr(str, kytu) <> 0 Then NhapkySo_vachamphay = True
        End If

    End Function
    Public Function NhapKySoVaDauCham(ByVal kytu As Char, ByVal str As String) As Boolean
        Dim strHople As String
        Dim i As Integer
        NhapKySoVaDauCham = False
        strHople = "0123456789."
        If Asc(kytu) <= 26 Then Exit Function
        i = InStr(str, ".") ' vị trí dấu .trong str
        If i > 0 Then  'nếu sau dấu . có đủ 3 ký số thì không nhận nữa
            If Mid(str, i + 1).Length = 3 Then
                NhapKySoVaDauCham = True
            End If
        End If
        If InStr(strHople, kytu) <> 0 Then NhapKySoVaDauCham = True
        If kytu = "." And i > 0 Then NhapKySoVaDauCham = True
    End Function
    Public Function Nhapkytu(ByVal kytu As Char) As Boolean
        Nhapkytu = False
        If kytu = Chr(13) Then
            My.Computer.Keyboard.SendKeys("{TAB}", False)
            Exit Function
        End If
        If Asc(kytu) >= 26 Then
            Dim str As String
            str = "AZERTYUIOPQSDFGHJKLMWXCVBN"
            If InStr(str, UCase(kytu)) <> 0 Then Nhapkytu = True
        End If

    End Function

#End Region
#Region "Enable và Disable nút lệnh và Textbox"
    Public Sub SetEnableOfButton(ByVal frm As Form, ByVal Active As Boolean)
        Dim ctl As Control

        ' Loop through controls,  ' looking for controls of Buttontype. 
        For Each ctl In frm.Controls
            If TypeOf (ctl) Is Button Then
                ' If the control is the correct type, change Enabled
                ctl.Enabled = Active
            End If
        Next

    End Sub
    Public Sub SetEnableOfTextBox(ByVal frm As Form, ByVal Active As Boolean)
        Dim ctl As Control

        ' Loop through controls,  ' looking for controls of Buttontype. 
        For Each ctl In frm.Controls
            If TypeOf (ctl) Is TextBox Then
                ' If the control is the correct type, change Enabled
                ctl.Enabled = Active
            End If
        Next

    End Sub
    Public Sub SetEnableOfComBox(ByVal frm As Form, ByVal Active As Boolean)
        Dim ctl As Control

        ' Loop through controls,  ' looking for controls of Buttontype. 
        For Each ctl In frm.Controls
            If TypeOf (ctl) Is ComboBox Then
                ' If the control is the correct type, change Enabled
                ctl.Enabled = Active
            End If
        Next

    End Sub
#End Region

#Region "Thực thi DML - SQL "
    Public Function ExecSPNonQuery(ByVal strLenh As String) As Integer
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strLenh
        If conn.State = ConnectionState.Closed Then
            KetNoi()
        End If
        Try
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            ExecSPNonQuery = 0
            Exit Function
        End Try
        ExecSPNonQuery = 1
    End Function

    Public Function ExecSELECTSQL(ByVal strLenh As String) As SqlDataReader
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strLenh
        If conn.State = ConnectionState.Closed Then
            ModuleTRACNGHIEM.KetNoi()
        End If
        Try
            ExecSELECTSQL = cmd.ExecuteReader()
        Catch ex As SqlException

        End Try
    End Function

    Public Function ExecSPNonQuery(ByVal tenSP As String, ByVal thamso() As String, ByVal giatri() As String) As Int32
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = tenSP
        For i = 0 To UBound(thamso)
            cmd.Parameters.Add(thamso(i), SqlDbType.NVarChar, 100).Value = giatri(i)
        Next
        If conn.State = ConnectionState.Closed Then
            ModuleTRACNGHIEM.KetNoi()
        End If
        Try
            ExecSPNonQuery = cmd.ExecuteNonQuery()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

    End Function
    Public Function ExecSPGetBindingSource(ByVal tenSP As String, ByVal thamso() As String, ByVal giatri() As String) As BindingSource
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = tenSP
        For i = 0 To UBound(thamso)
            cmd.Parameters.Add(thamso(i), SqlDbType.NVarChar, 100).Value = giatri(i)
        Next

        If conn.State = ConnectionState.Closed Then
            ModuleTRACNGHIEM.KetNoi()
        End If
        Try
            Dim reader As SqlDataReader
            Dim bds As New BindingSource
            reader = cmd.ExecuteReader()
            bds.DataSource = reader
            reader.Close()
            ExecSPGetBindingSource = bds
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

    End Function
#End Region

    Public Function Doitien(ByVal Tienso As Long) As String

        Dim Donvi, tram, ti As String
        Donvi = "   MoätHai Ba  BoánNaêmSaùuBaûyTaùmChín"
        tram = "    TraêmMöôi    "
        ti = "     Tæ    TrieäuNgaøn      "
        Dim Tienchu As String
        Dim k, j, i As Byte
        Dim Temp, Code As Integer
        Dim S, Tien As String
        Dim roi As Boolean
        Tienchu = ""
        Tien = CStr(Tienso)
        Do While Len(Tien) < 12
            Tien = " " & Tien
        Loop
        i = 1
        Do While i <= 4
            S = Mid(Tien, 3 * i - 2, 3)
            If (S <> "   ") And (S <> "000") Then
                Temp = Val(S)
                j = 1
                roi = False
                Do While j <= 3

                    k = Val(Mid(S, j, 1)) '  Lay ra tung so 1
                    If k <> 0 Then
                        If (j = 2) And (k = 1) Then
                            Tienchu = Tienchu + "Möôøi "
                        Else
                            If (j = 3) And (k = 1) And (Right(Tienchu, 5) = "Möôi ") Then
                                Tienchu = Tienchu + "Moát "
                            Else
                                If j = 3 Then
                                    If (Mid(S, 2, 1) <> "0") Then
                                        If (k = 5) And (Mid(S, 2, 1) <> " ") Then Tienchu = Tienchu & " Laêm " Else Tienchu = Tienchu & Mid(Donvi, k * 4, 4)
                                    Else
                                        Tienchu = Tienchu + "Leõ " + Mid(Donvi, k * 4, 4)
                                    End If
                                Else  ' cua j = 3 ie  j = 1, hay , j=2 v§ k =2..9 *)
                                    Tienchu = Tienchu & RTrim(Mid(Donvi, k * 4, 4)) + " " + RTrim(Mid(tram, j * 5, 5)) + " "
                                End If     ' j = 3
                            End If       ' j = 3 va k=1 va RightStr...
                        End If         ' j=2 va k=1
                    Else  ' if k <> 0
                        If Mid(S, 1, 1) = "0" And roi = False Then Tienchu = Tienchu + "Khoâng Traêm " : roi = True
                    End If         ' if k <> 0
                    j = j + 1
                Loop     ' While j
                Tienchu = RTrim(Tienchu) + " " + RTrim(Mid(ti, i * 6, 6)) + " "
            End If
            i = i + 1
        Loop '  While i
        Tienchu = RTrim(Tienchu)
        If Right(Tienchu, 2) = "Leõ" Then Tienchu = RTrim(Mid(Tienchu, 1, Len(Tienchu) - 2))
        Doitien = Tienchu & " Ñoàng Chaün"

    End Function
End Module
