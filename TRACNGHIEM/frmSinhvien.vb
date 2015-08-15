Public Class frmSinhvien
    'Khai báo 1 biến để biết rằng mình đang chọn bảng nào, lớp hoặc sinh viên
    Dim bangLop = True
    Dim vitri As Integer

    Private Sub frmSinhvien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.Sinhvien' table. You can move, or remove it, as needed.
        daLOP.Fill(DS, "LOP")
        Me.SinhvienTableAdapter.Fill(Me.DS.Sinhvien)
    End Sub

    'Hàm này dùng để thêm mới 1 lớp, hiểu chưa?

    Private Sub themLop()
        vitri = bdsLOP.Position
        bdsLOP.AddNew()

        dgvLOP.Enabled = False
        btnThem.Enabled = False
        btnGhi.Enabled = True
        btnXoa.Enabled = False
        btnHieuchinh.Enabled = False
        btnTim.Enabled = False
        btnPhuchoi.Enabled = True

        txtMALOP.Focus()

    End Sub

    Private Sub hieuChinhLop()
        If txtMALOP.Text.Trim = "" Then
            MsgBox("Mã lớp không được để trống", MsgBoxStyle.Information)
            txtMALOP.Focus()
            Exit Sub
        End If

        If txtTENLOP.Text.Trim = "" Then
            MsgBox("Tên lớp không được để trống", MsgBoxStyle.Information)
            txtTENLOP.Focus()
            Exit Sub
        End If

        Try
            bdsLOP.EndEdit()
            bdsLOP.ResetCurrentItem()
            daLOP.Update(DS, "LOP")
        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi thêm lớp" & vbCrLf & _
            Err.Description & vbCrLf & Err.Source)

        End Try
        dgvLOP.Enabled = True
    End Sub
    Private Sub ghiLop()
        If txtMALOP.Text.Trim = "" Then
            MsgBox("Mã lớp không được để trống", MsgBoxStyle.Information)
            txtMALOP.Focus()
            Exit Sub
        End If

        If txtTENLOP.Text.Trim = "" Then
            MsgBox("Tên môn học không được để trống", MsgBoxStyle.Information)
            txtTENLOP.Focus()
            Exit Sub
        End If
        Try
            bdsLOP.EndEdit()
            bdsLOP.ResetCurrentItem()
            daLOP.Update(DS, "LOP")
        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi thêm lớp" & vbCrLf & _
            Err.Description & vbCrLf & Err.Source)

        End Try
        dgvLOP.Enabled = True
    End Sub
    Private Sub timLop()
        Dim tenlop As String
        tenlop = InputBox("Nhập tên lớp")

        If tenlop.Trim = "" Then
            bdsLOP.RemoveFilter()
        Else
            bdsLOP.Filter = "[TENLOP] = '" & tenlop & "'"
        End If

    End Sub

    Private Sub xoaLop()
        Dim yn As DialogResult
        yn = MsgBox("Bạn có muốn xóa lớp này?", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdsLOP.RemoveCurrent()
                daLOP.Update(DS, "LOP")
            Catch ex As Exception
                MsgBox("Không thể lớp này", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub phuchoiLop()
        bdsLOP.CancelEdit()
        bdsLOP.Position = vitri
        dgvLOP.Enabled = True
        btnThem.Enabled = True
        btnGhi.Enabled = True
        btnXoa.Enabled = True
        btnHieuchinh.Enabled = True
        btnTim.Enabled = True
    End Sub

    'hàm này dùng để thêm mới 1 sinh viên, hiểu
    Private Sub themSV()
        vitri = bdsSV.Position
        bdsSV.AddNew()

        dgvSV.Enabled = False
        btnThem.Enabled = False
        btnGhi.Enabled = True
        btnXoa.Enabled = False
        btnHieuchinh.Enabled = False
        btnTim.Enabled = False
        btnPhuchoi.Enabled = True

        txtMASV.Focus()

    End Sub
    Private Sub hieuChinhSV()
        If txtMASV.Text.Trim = "" Then
            MsgBox("Mã sinh viên không được để trống", MsgBoxStyle.Information)
            txtMASV.Focus()
            Exit Sub
        End If

        If txtTEN.Text.Trim = "" Then
            MsgBox("Tên sinh viên không được để trống", MsgBoxStyle.Information)
            txtTEN.Focus()
            Exit Sub
        End If
        If txtHO.Text.Trim = "" Then
            MsgBox("Họ sinh viên không được để trống", MsgBoxStyle.Information)
            txtHO.Focus()
            Exit Sub
        End If
        If txtMALOP.Text.Trim = "" Then
            MsgBox("Mã lớp không được để trống", MsgBoxStyle.Information)
            txtMALOP.Focus()
            Exit Sub
        End If
        Try
            bdsSV.EndEdit()
            bdsSV.ResetCurrentItem()
            daLOP.Update(DS, "LOP")
        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi thêm sinh viên" & vbCrLf & _
            Err.Description & vbCrLf & Err.Source)

        End Try
        dgvLOP.Enabled = True
    End Sub
    Private Sub ghiSV()
        If txtMASV.Text.Trim = "" Then
            MsgBox("Mã sinh viên không được để trống", MsgBoxStyle.Information)
            txtMASV.Focus()
            Exit Sub
        End If

        If txtTEN.Text.Trim = "" Then
            MsgBox("Tên sinh viên không được để trống", MsgBoxStyle.Information)
            txtTEN.Focus()
            Exit Sub
        End If
        If txtHO.Text.Trim = "" Then
            MsgBox("Họ sinh viên không được để trống", MsgBoxStyle.Information)
            txtHO.Focus()
            Exit Sub
        End If
        If txtMASV.Text.Trim = "" Then
            MsgBox("Mã sinh viên không được để trống", MsgBoxStyle.Information)
            txtMASV.Focus()
            Exit Sub
        End If
        Try
            bdsSV.EndEdit()
            bdsSV.ResetCurrentItem()
            daLOP.Update(DS, "LOP")
        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi thêm sinh viên" & vbCrLf & _
            Err.Description & vbCrLf & Err.Source)

        End Try
        dgvSV.Enabled = True
    End Sub
    Private Sub timSV()
        Dim tenSV As String
        tenSV = InputBox("Nhập tên sinh viên")

        If tenSV.Trim = "" Then
            bdsSV.RemoveFilter()
        Else
            bdsSV.Filter = "[TEN] = '" & tenSV & "'"
        End If

    End Sub

    Private Sub xoaSV()
        Dim yn As DialogResult
        yn = MsgBox("Bạn có muốn xóa sinh viên này?", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdsSV.RemoveCurrent()
                daLOP.Update(DS, "LOP")
            Catch ex As Exception
                MsgBox("Không thể xóa sinh viên này", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub phuchoiSV()
        bdsLOP.CancelEdit()
        bdsLOP.Position = vitri
        dgvLOP.Enabled = True
        btnThem.Enabled = True
        btnGhi.Enabled = True
        btnXoa.Enabled = True
        btnHieuchinh.Enabled = True
        btnTim.Enabled = True
    End Sub

    'Private Sub btnThemLOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemLOP.Click
    '    vitri = bdsLop.Position
    '    bdsLop.AddNew()

    '    dgvLop.Enabled = False
    '    btnThemLOP.Enabled = False
    '    btnGhiLOP.Enabled = True
    '    btnXoaLOP.Enabled = False
    '    btnHieuchinhLOP.Enabled = False
    '    btnTimLOP.Enabled = False
    '    btnPhuchoiLOP.Enabled = True

    '    txtMALOP.Focus()
    'End Sub

    'Private Sub btnTimLOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimLOP.Click
    '    Dim tenlop As String
    '    tenlop = InputBox("Nhập tên lớp")

    '    If tenlop.Trim = "" Then
    '        bdsLop.RemoveFilter()
    '    Else
    '        bdsLop.Filter = "[TENLOP] = '" & tenlop & "'"
    '    End If

    'End Sub

    'Private Sub btnHieuchinhLOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHieuchinhLOP.Click
    '    If txtMALOP.Text.Trim = "" Then
    '        MsgBox("Mã lớp không được để trống", MsgBoxStyle.Information)
    '        txtMALOP.Focus()
    '        Exit Sub
    '    End If

    '    If txtTENLOP.Text.Trim = "" Then
    '        MsgBox("Tên lớp không được để trống", MsgBoxStyle.Information)
    '        txtTENLOP.Focus()
    '        Exit Sub
    '    End If

    '    Try
    '        bdsLop.EndEdit()
    '        bdsLop.ResetCurrentItem()
    '        daLop.Update(DS, "GIAOVIEN")
    '    Catch ex As DBConcurrencyException
    '    Catch ex As Exception
    '        MsgBox("Lỗi thêm lớp" & vbCrLf & _
    '        Err.Description & vbCrLf & Err.Source)

    '    End Try
    '    dgvLop.Enabled = True
    'End Sub

    'Private Sub btnGhiLOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhiLOP.Click
    '    If txtMALOP.Text.Trim = "" Then
    '        MsgBox("Mã lớp không được để trống", MsgBoxStyle.Information)
    '        txtMALOP.Focus()
    '        Exit Sub
    '    End If

    '    If txtTENLOP.Text.Trim = "" Then
    '        MsgBox("Tên môn học không được để trống", MsgBoxStyle.Information)
    '        txtTENLOP.Focus()
    '        Exit Sub
    '    End If
    '    Try
    '        bdsLop.EndEdit()
    '        bdsLop.ResetCurrentItem()
    '        daLop.Update(DS, "MONHOC")
    '    Catch ex As DBConcurrencyException
    '    Catch ex As Exception
    '        MsgBox("Lỗi thêm lớp" & vbCrLf & _
    '        Err.Description & vbCrLf & Err.Source)

    '    End Try
    '    dgvLop.Enabled = True
    'End Sub

    'Private Sub btnXoaLOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoaLOP.Click
    '    Dim yn As DialogResult
    '    yn = MsgBox("Bạn có muốn xóa lớp này?", MsgBoxStyle.YesNo)
    '    If yn = Windows.Forms.DialogResult.Yes Then
    '        Try
    '            bdsLop.RemoveCurrent()
    '            daLop.Update(DS, "MONHOC")
    '        Catch ex As Exception
    '            MsgBox("Không thể lớp này", MsgBoxStyle.Information)
    '            Exit Sub
    '        End Try
    '    End If
    'End Sub

    'Private Sub btnPhuchoiLOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhuchoiLOP.Click
    '    bdsLop.CancelEdit()
    '    bdsLop.Position = vitri
    '    dgvLop.Enabled = True
    '    btnThemLOP.Enabled = True
    '    btnGhiLOP.Enabled = True
    '    btnXoaLOP.Enabled = True
    '    btnHieuchinhLOP.Enabled = True
    '    btnTimLOP.Enabled = True
    'End Sub

    'Private Sub LOPBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.LOPBindingSource.EndEdit()
    '    Me.LOPTableAdapter.Update(Me.DS.LOP)

    'End Sub


    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click

        If (dgvLOP.SelectedRows.Count > 0) Then
            bangLop = True
        Else
            bangLop = False
        End If


        If (bangLop = True) Then
            themLop()
        Else
            themSV()

        End If

    End Sub

    Private Sub btnHieuchinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHieuchinh.Click
        If (bangLop = True) Then
            hieuChinhLop()
        End If
    End Sub

    Private Sub btnTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTim.Click
        If (dgvLOP.SelectedRows.Count > 0) Then
            bangLop = True
        Else
            bangLop = False
        End If


        If (bangLop = True) Then
            timLop()
        Else
            timSV()

        End If
    End Sub

    Private Sub btnGhi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhi.Click
        If (dgvLOP.SelectedRows.Count > 0) Then
            bangLop = True
        Else
            bangLop = False
        End If


        If (bangLop = True) Then
            ghiLop()
        Else
            ghiSV()

        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If (dgvLOP.SelectedRows.Count > 0) Then
            bangLop = True
        Else
            bangLop = False
        End If


        If (bangLop = True) Then
            xoaLop()
        Else
            xoaSV()

        End If
    End Sub

    Private Sub btnPhuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhuchoi.Click
        If (dgvLOP.SelectedRows.Count > 0) Then
            bangLop = True
        Else
            bangLop = False
        End If


        If (bangLop = True) Then
            phuchoiLop()
        Else
            phuchoiSV()

        End If
    End Sub

End Class