Imports System.Data.SqlClient

Public Class frmDangky
    Dim vitri As Integer

    Private Sub frmDangky_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.CHONGIAOVIEN' table. You can move, or remove it, as needed.
        Me.CHONGIAOVIENTableAdapter.Fill(Me.DS.CHONGIAOVIEN)
        'TODO: This line of code loads data into the 'DS.CHONMONHOC' table. You can move, or remove it, as needed.
        Me.CHONMONHOCTableAdapter.Fill(Me.DS.CHONMONHOC)
        'TODO: This line of code loads data into the 'DS.CHONLOP' table. You can move, or remove it, as needed.
        Me.CHONLOPTableAdapter.Fill(Me.DS.CHONLOP)
        'TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
        Me.GIAOVIEN_DANGKYTableAdapter.Fill(Me.DS.GIAOVIEN_DANGKY)
        daSOCAUHOI.Fill(DS, "SOCAUHOI")
    End Sub

    Private Sub cmbGV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGV.SelectedIndexChanged
        txtMAGV.Text = cmbGV.SelectedValue
    End Sub

    Private Sub cmbLOP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLOP.SelectedIndexChanged
        txtMALOP.Text = cmbLOP.SelectedValue
    End Sub

    Private Sub cmbMH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMH.SelectedIndexChanged
        txtMAMH.Text = cmbMH.SelectedValue
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        vitri = bdsGIAOVIEN_DANGKY.Position
        bdsGIAOVIEN_DANGKY.AddNew()

        dgvGIAOVIEN_DANGKY.Enabled = False
        btnThem.Enabled = False
        btnGhi.Enabled = True
        btnPhuchoi.Enabled = True

        xoatrangNhap()
    End Sub

    Private Sub xoatrangNhap()
        cmbGV.SelectedIndex = -1
        cmbLOP.SelectedIndex = -1
        cmbMH.SelectedIndex = -1
        cmbTRINHDO.SelectedIndex = -1
        cmbLAN.SelectedIndex = -1
        numSOCAUTHI.Value = 0
        numTHOIGIAN.Value = 0
        dtpNGAYTHI.Value = DateTime.Now
    End Sub

    Private Sub btnGhi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhi.Click
        If txtMAGV.Text = "" Then
            MsgBox("Chọn giáo viên", MsgBoxStyle.Information)
            cmbGV.DroppedDown = True
            Exit Sub
        End If
        If txtMALOP.Text = "" Then
            MsgBox("Chọn lớp", MsgBoxStyle.Information)
            cmbLOP.DroppedDown = True
            Exit Sub
        End If
        If txtMAMH.Text = "" Then
            MsgBox("Chọn lớp", MsgBoxStyle.Information)
            cmbMH.DroppedDown = True
            Exit Sub
        End If
        If cmbTRINHDO.Text = "" Then
            MsgBox("Chọn trình độ", MsgBoxStyle.Information)
            cmbTRINHDO.DroppedDown = True
            Exit Sub
        End If
        If cmbLAN.Text = "" Then
            MsgBox("Chọn số lần thi", MsgBoxStyle.Information)
            cmbLAN.DroppedDown = True
            Exit Sub
        End If
        If numSOCAUTHI.Value < 10 Or numSOCAUTHI.Value > 100 Then
            MsgBox("Số câu thi từ 10 đến 100", MsgBoxStyle.Information)
            numSOCAUTHI.Focus()
            Exit Sub
        Else
            'Dim strQuery As String = "MAGV='" & txtMAGV.Text & "' and MAMH='" & txtMAMH.Text & "'"
            'Dim rows = DS.SOCAUHOI.Select(strQuery)

            'If rows.Length > 0 Then
            '    Dim socauhoi As Integer = CType(rows(0)("SOCAUHOI"), Integer)
            '    If socauhoi < numSOCAUTHI.Value Then
            '        MsgBox("Số câu thi hiện tại trong bộ đề chỉ có " & socauhoi & ", không đủ để đăng ký", MsgBoxStyle.Information)
            '        Exit Sub
            '    End If
            'End If
            Dim strQuery As String = "SELECT MAMH, MAGV, COUNT(CAUHOI) AS SOCAUHOI FROM BODE GROUP BY MAMH, MAGV"
            Dim reader As SqlDataReader = ModuleTRACNGHIEM.ExecSELECTSQL(strQuery)

            If reader.HasRows Then
                While reader.Read
                    Dim socauhoi As Integer = reader.GetInt32(2)
                    If socauhoi < numSOCAUTHI.Value Then
                        MsgBox("Số câu thi hiện tại trong bộ đề chỉ có " & socauhoi & ", không đủ để đăng ký", MsgBoxStyle.Information)
                        Exit Sub
                    End If

                End While
                reader.Close()
            End If

        End If

        If dtpNGAYTHI.Value.Date < DateTime.Now.Date Then
            MsgBox("Ngày thi không được nhỏ hơn ngày hiện tại", MsgBoxStyle.Information)
            dtpNGAYTHI.Focus()
            Exit Sub
        End If

        If numTHOIGIAN.Value < 15 Or numTHOIGIAN.Value > 60 Then
            MsgBox("Thời gian thi phải từ 15 phút đến 60 phút", MsgBoxStyle.Information)
            numTHOIGIAN.Focus()
            Exit Sub
        End If

        Try ' Thực hiện ghi vào database, xảy ra lỗi ở đâu thì dừng lại và thực hiện catch
            bdsGIAOVIEN_DANGKY.EndEdit()
            bdsGIAOVIEN_DANGKY.ResetCurrentItem()
            GIAOVIEN_DANGKYTableAdapter.Update(DS.GIAOVIEN_DANGKY)
            btnThem.Enabled = True

        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi đăng ký thi" & vbCrLf & _
                Err.Description & vbCrLf & Err.Source)
        End Try
    End Sub

    Private Sub btnPhuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhuchoi.Click
        bdsGIAOVIEN_DANGKY.CancelEdit()
        bdsGIAOVIEN_DANGKY.Position = vitri
        dgvGIAOVIEN_DANGKY.Enabled = True
        btnThem.Enabled = True
        btnGhi.Enabled = True

    End Sub
End Class