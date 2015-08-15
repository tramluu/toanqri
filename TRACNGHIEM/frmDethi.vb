Public Class frmDethi
    Dim vitri As Integer
    Dim mamh As String
    Dim magv As String
    Dim trinhdo As String

    Private Sub frmDethi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.CHONGIAOVIEN' table. You can move, or remove it, as needed.
        Me.CHONGIAOVIENTableAdapter.Fill(Me.DS.CHONGIAOVIEN)
        'TODO: This line of code loads data into the 'DS.CHONMONHOC' table. You can move, or remove it, as needed.
        Me.CHONMONHOCTableAdapter.Fill(Me.DS.CHONMONHOC)
        'TODO: This line of code loads data into the 'DS.BODE' table. You can move, or remove it, as needed.
        Me.BODETableAdapter.Fill(Me.DS.BODE)

        btnNhapcauhoi.Enabled = False
        btnKetthuc.Enabled = False

    End Sub

    Private Sub cmbMH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMH.SelectedIndexChanged
        txtMAMH.Text = cmbMH.SelectedValue
    End Sub

    Private Sub cmbGV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGV.SelectedIndexChanged
        txtMAGV.Text = cmbGV.SelectedValue
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        vitri = bdsBODE.Position
        bdsBODE.AddNew()

        dgvBODE.Enabled = False
        btnThem.Enabled = False
        btnGhi.Enabled = True
        btnPhuchoi.Enabled = True

        btnNhapcauhoi.Enabled = True
        btnKetthuc.Enabled = True
        btnGhi.Enabled = False

        xoatrangNhap()
    End Sub

    Private Sub btnNhapcauhoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNhapcauhoi.Click
        If txtMAMH.Text = "" Then
            MsgBox("Xin chọn môn học", MsgBoxStyle.Information)
            cmbMH.DroppedDown = True
            Exit Sub
        End If
        If txtMAGV.Text = "" Then
            MsgBox("Xin chọn giáo viên", MsgBoxStyle.Information)
            cmbGV.DroppedDown = True
            Exit Sub
        End If
        If cmbTRINHDO.Text = "" Then
            MsgBox("Xin chọn trình độ", MsgBoxStyle.Information)
            cmbTRINHDO.DroppedDown = True
            Exit Sub
        End If

        btnGhi.Enabled = True
        btnNhapcauhoi.Enabled = False
        cmbMH.Enabled = False
        cmbGV.Enabled = False
        btnPhuchoi.Enabled = False

        mamh = txtMAMH.Text
        magv = txtMAGV.Text
        trinhdo = cmbTRINHDO.SelectedItem
    End Sub

    Private Sub btnPhuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhuchoi.Click
        bdsBODE.CancelEdit()
        bdsBODE.Position = vitri
        dgvBODE.Enabled = True
        btnThem.Enabled = True
        btnGhi.Enabled = True
        btnNhapcauhoi.Enabled = False
        btnKetthuc.Enabled = False
    End Sub

    Private Sub btnKetthuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKetthuc.Click
        btnGhi.Enabled = False
        btnNhapcauhoi.Enabled = True
        cmbMH.Enabled = True
        cmbGV.Enabled = True
        cmbTRINHDO.Enabled = True
        btnPhuchoi.Enabled = True
    End Sub

    Private Sub btnGhi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhi.Click
        If numCAUHOI.Value <= 0 Then
            MsgBox("Câu hỏi phải lớn hơn 0", MsgBoxStyle.Information)
            numCAUHOI.Focus()
            Exit Sub
        End If
        If txtNOIDUNG.Text.Trim = "" Then
            MsgBox("Xin nhập nội dung câu hỏi", MsgBoxStyle.Information)
            txtNOIDUNG.Focus()
            Exit Sub
        End If
        If txtA.Text.Trim = "" Then
            MsgBox("Xin nhập câu trả lời", MsgBoxStyle.Information)
            txtA.Focus()
            Exit Sub
        End If
        If txtB.Text.Trim = "" Then
            MsgBox("Xin nhập câu trả lời", MsgBoxStyle.Information)
            txtB.Focus()
            Exit Sub
        End If
        If txtC.Text.Trim = "" Then
            MsgBox("Xin nhập câu trả lời", MsgBoxStyle.Information)
            txtC.Focus()
            Exit Sub
        End If
        If txtD.Text.Trim = "" Then
            MsgBox("Xin nhập câu trả lời", MsgBoxStyle.Information)
            txtD.Focus()
            Exit Sub
        End If

        If cmbDAPAN.Text = "" Then
            MsgBox("Xin chọn đáp án", MsgBoxStyle.Information)
            cmbDAPAN.DroppedDown = True
            Exit Sub
        End If

        Try ' Thực hiện ghi vào database, xảy ra lỗi ở đâu thì dừng lại và thực hiện catch
            bdsBODE.EndEdit()
            bdsBODE.ResetCurrentItem()
            BODETableAdapter.Update(DS.BODE)
            bdsBODE.AddNew()
            txtMAMH.Text = mamh
            txtMAGV.Text = magv
            cmbTRINHDO.SelectedIndex = -1
            cmbTRINHDO.SelectedIndex = cmbTRINHDO.FindStringExact(trinhdo)

            numCAUHOI.Value = 0
            cmbDAPAN.SelectedIndex = -1
        Catch ex As DBConcurrencyException
        Catch ex As Exception
            MsgBox("Lỗi thêm câu hỏi" & vbCrLf & _
                Err.Description & vbCrLf & Err.Source)
        End Try
    End Sub

    Private Sub xoatrangNhap()
        cmbMH.SelectedIndex = -1
        cmbGV.SelectedIndex = -1
        cmbTRINHDO.SelectedIndex = -1
        numCAUHOI.Value = 0
        txtNOIDUNG.Text = ""
        txtA.Text = ""
        txtB.Text = ""
        txtC.Text = ""
        txtD.Text = ""
        cmbDAPAN.SelectedIndex = -1
    End Sub
End Class