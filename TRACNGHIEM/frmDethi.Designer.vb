<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDethi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TENMHLabel As System.Windows.Forms.Label
        Dim HOTENLabel As System.Windows.Forms.Label
        Dim TRINHDOLabel As System.Windows.Forms.Label
        Dim CAUHOILabel As System.Windows.Forms.Label
        Dim NOIDUNGLabel As System.Windows.Forms.Label
        Dim ALabel As System.Windows.Forms.Label
        Dim BLabel As System.Windows.Forms.Label
        Dim CLabel As System.Windows.Forms.Label
        Dim DLabel As System.Windows.Forms.Label
        Dim DAPANLabel As System.Windows.Forms.Label
        Me.DS = New TRACNGHIEM.DS
        Me.bdsBODE = New System.Windows.Forms.BindingSource(Me.components)
        Me.BODETableAdapter = New TRACNGHIEM.DSTableAdapters.BODETableAdapter
        Me.dgvBODE = New System.Windows.Forms.DataGridView
        Me.CHONMONHOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CHONMONHOCTableAdapter = New TRACNGHIEM.DSTableAdapters.CHONMONHOCTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnKetthuc = New System.Windows.Forms.Button
        Me.btnNhapcauhoi = New System.Windows.Forms.Button
        Me.cmbDAPAN = New System.Windows.Forms.ComboBox
        Me.txtD = New System.Windows.Forms.TextBox
        Me.txtC = New System.Windows.Forms.TextBox
        Me.txtB = New System.Windows.Forms.TextBox
        Me.txtA = New System.Windows.Forms.TextBox
        Me.txtNOIDUNG = New System.Windows.Forms.TextBox
        Me.numCAUHOI = New System.Windows.Forms.NumericUpDown
        Me.cmbTRINHDO = New System.Windows.Forms.ComboBox
        Me.txtMAGV = New System.Windows.Forms.TextBox
        Me.cmbGV = New System.Windows.Forms.ComboBox
        Me.CHONGIAOVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtMAMH = New System.Windows.Forms.TextBox
        Me.cmbMH = New System.Windows.Forms.ComboBox
        Me.CHONGIAOVIENTableAdapter = New TRACNGHIEM.DSTableAdapters.CHONGIAOVIENTableAdapter
        Me.btnThem = New System.Windows.Forms.Button
        Me.btnPhuchoi = New System.Windows.Forms.Button
        Me.btnGhi = New System.Windows.Forms.Button
        Me.btnChinhsua = New System.Windows.Forms.Button
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        TENMHLabel = New System.Windows.Forms.Label
        HOTENLabel = New System.Windows.Forms.Label
        TRINHDOLabel = New System.Windows.Forms.Label
        CAUHOILabel = New System.Windows.Forms.Label
        NOIDUNGLabel = New System.Windows.Forms.Label
        ALabel = New System.Windows.Forms.Label
        BLabel = New System.Windows.Forms.Label
        CLabel = New System.Windows.Forms.Label
        DLabel = New System.Windows.Forms.Label
        DAPANLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsBODE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBODE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHONMONHOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numCAUHOI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHONGIAOVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TENMHLabel
        '
        TENMHLabel.AutoSize = True
        TENMHLabel.Location = New System.Drawing.Point(14, 29)
        TENMHLabel.Name = "TENMHLabel"
        TENMHLabel.Size = New System.Drawing.Size(62, 16)
        TENMHLabel.TabIndex = 0
        TENMHLabel.Text = "Môn học:"
        '
        'HOTENLabel
        '
        HOTENLabel.AutoSize = True
        HOTENLabel.Location = New System.Drawing.Point(12, 70)
        HOTENLabel.Name = "HOTENLabel"
        HOTENLabel.Size = New System.Drawing.Size(64, 16)
        HOTENLabel.TabIndex = 3
        HOTENLabel.Text = "Giáo viên:"
        '
        'TRINHDOLabel
        '
        TRINHDOLabel.AutoSize = True
        TRINHDOLabel.Location = New System.Drawing.Point(15, 111)
        TRINHDOLabel.Name = "TRINHDOLabel"
        TRINHDOLabel.Size = New System.Drawing.Size(61, 16)
        TRINHDOLabel.TabIndex = 6
        TRINHDOLabel.Text = "Trình độ:"
        '
        'CAUHOILabel
        '
        CAUHOILabel.AutoSize = True
        CAUHOILabel.Location = New System.Drawing.Point(163, 111)
        CAUHOILabel.Name = "CAUHOILabel"
        CAUHOILabel.Size = New System.Drawing.Size(54, 16)
        CAUHOILabel.TabIndex = 8
        CAUHOILabel.Text = "Câu hỏi:"
        '
        'NOIDUNGLabel
        '
        NOIDUNGLabel.AutoSize = True
        NOIDUNGLabel.Location = New System.Drawing.Point(332, 44)
        NOIDUNGLabel.Name = "NOIDUNGLabel"
        NOIDUNGLabel.Size = New System.Drawing.Size(63, 16)
        NOIDUNGLabel.TabIndex = 10
        NOIDUNGLabel.Text = "Nội dung:"
        '
        'ALabel
        '
        ALabel.AutoSize = True
        ALabel.Location = New System.Drawing.Point(395, 108)
        ALabel.Name = "ALabel"
        ALabel.Size = New System.Drawing.Size(20, 16)
        ALabel.TabIndex = 12
        ALabel.Text = "A:"
        '
        'BLabel
        '
        BLabel.AutoSize = True
        BLabel.Location = New System.Drawing.Point(572, 108)
        BLabel.Name = "BLabel"
        BLabel.Size = New System.Drawing.Size(19, 16)
        BLabel.TabIndex = 14
        BLabel.Text = "B:"
        '
        'CLabel
        '
        CLabel.AutoSize = True
        CLabel.Location = New System.Drawing.Point(395, 147)
        CLabel.Name = "CLabel"
        CLabel.Size = New System.Drawing.Size(20, 16)
        CLabel.TabIndex = 16
        CLabel.Text = "C:"
        '
        'DLabel
        '
        DLabel.AutoSize = True
        DLabel.Location = New System.Drawing.Point(572, 147)
        DLabel.Name = "DLabel"
        DLabel.Size = New System.Drawing.Size(21, 16)
        DLabel.TabIndex = 18
        DLabel.Text = "D:"
        '
        'DAPANLabel
        '
        DAPANLabel.AutoSize = True
        DAPANLabel.Location = New System.Drawing.Point(584, 195)
        DAPANLabel.Name = "DAPANLabel"
        DAPANLabel.Size = New System.Drawing.Size(51, 16)
        DAPANLabel.TabIndex = 20
        DAPANLabel.Text = "Đáp án:"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bdsBODE
        '
        Me.bdsBODE.DataMember = "BODE"
        Me.bdsBODE.DataSource = Me.DS
        '
        'BODETableAdapter
        '
        Me.BODETableAdapter.ClearBeforeFill = True
        '
        'dgvBODE
        '
        Me.dgvBODE.AutoGenerateColumns = False
        Me.dgvBODE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBODE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvBODE.DataSource = Me.bdsBODE
        Me.dgvBODE.Location = New System.Drawing.Point(10, 261)
        Me.dgvBODE.Name = "dgvBODE"
        Me.dgvBODE.Size = New System.Drawing.Size(860, 210)
        Me.dgvBODE.TabIndex = 1
        '
        'CHONMONHOCBindingSource
        '
        Me.CHONMONHOCBindingSource.DataMember = "CHONMONHOC"
        Me.CHONMONHOCBindingSource.DataSource = Me.DS
        '
        'CHONMONHOCTableAdapter
        '
        Me.CHONMONHOCTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnKetthuc)
        Me.GroupBox1.Controls.Add(Me.btnNhapcauhoi)
        Me.GroupBox1.Controls.Add(DAPANLabel)
        Me.GroupBox1.Controls.Add(Me.cmbDAPAN)
        Me.GroupBox1.Controls.Add(DLabel)
        Me.GroupBox1.Controls.Add(Me.txtD)
        Me.GroupBox1.Controls.Add(CLabel)
        Me.GroupBox1.Controls.Add(Me.txtC)
        Me.GroupBox1.Controls.Add(BLabel)
        Me.GroupBox1.Controls.Add(Me.txtB)
        Me.GroupBox1.Controls.Add(ALabel)
        Me.GroupBox1.Controls.Add(Me.txtA)
        Me.GroupBox1.Controls.Add(NOIDUNGLabel)
        Me.GroupBox1.Controls.Add(Me.txtNOIDUNG)
        Me.GroupBox1.Controls.Add(CAUHOILabel)
        Me.GroupBox1.Controls.Add(Me.numCAUHOI)
        Me.GroupBox1.Controls.Add(TRINHDOLabel)
        Me.GroupBox1.Controls.Add(Me.cmbTRINHDO)
        Me.GroupBox1.Controls.Add(Me.txtMAGV)
        Me.GroupBox1.Controls.Add(HOTENLabel)
        Me.GroupBox1.Controls.Add(Me.cmbGV)
        Me.GroupBox1.Controls.Add(Me.txtMAMH)
        Me.GroupBox1.Controls.Add(TENMHLabel)
        Me.GroupBox1.Controls.Add(Me.cmbMH)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(733, 233)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnKetthuc
        '
        Me.btnKetthuc.Location = New System.Drawing.Point(218, 166)
        Me.btnKetthuc.Name = "btnKetthuc"
        Me.btnKetthuc.Size = New System.Drawing.Size(88, 32)
        Me.btnKetthuc.TabIndex = 23
        Me.btnKetthuc.Text = "Kết thúc"
        Me.btnKetthuc.UseVisualStyleBackColor = True
        '
        'btnNhapcauhoi
        '
        Me.btnNhapcauhoi.Location = New System.Drawing.Point(79, 166)
        Me.btnNhapcauhoi.Name = "btnNhapcauhoi"
        Me.btnNhapcauhoi.Size = New System.Drawing.Size(133, 32)
        Me.btnNhapcauhoi.TabIndex = 22
        Me.btnNhapcauhoi.Text = "Nhập câu hỏi"
        Me.btnNhapcauhoi.UseVisualStyleBackColor = True
        '
        'cmbDAPAN
        '
        Me.cmbDAPAN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsBODE, "DAPAN", True))
        Me.cmbDAPAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDAPAN.FormattingEnabled = True
        Me.cmbDAPAN.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cmbDAPAN.Location = New System.Drawing.Point(637, 192)
        Me.cmbDAPAN.Name = "cmbDAPAN"
        Me.cmbDAPAN.Size = New System.Drawing.Size(79, 23)
        Me.cmbDAPAN.TabIndex = 21
        '
        'txtD
        '
        Me.txtD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsBODE, "D", True))
        Me.txtD.Location = New System.Drawing.Point(593, 144)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(123, 23)
        Me.txtD.TabIndex = 19
        '
        'txtC
        '
        Me.txtC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsBODE, "C", True))
        Me.txtC.Location = New System.Drawing.Point(415, 144)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(123, 23)
        Me.txtC.TabIndex = 17
        '
        'txtB
        '
        Me.txtB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsBODE, "B", True))
        Me.txtB.Location = New System.Drawing.Point(593, 105)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(123, 23)
        Me.txtB.TabIndex = 15
        '
        'txtA
        '
        Me.txtA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsBODE, "A", True))
        Me.txtA.Location = New System.Drawing.Point(415, 105)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(123, 23)
        Me.txtA.TabIndex = 13
        '
        'txtNOIDUNG
        '
        Me.txtNOIDUNG.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsBODE, "NOIDUNG", True))
        Me.txtNOIDUNG.Location = New System.Drawing.Point(397, 26)
        Me.txtNOIDUNG.Multiline = True
        Me.txtNOIDUNG.Name = "txtNOIDUNG"
        Me.txtNOIDUNG.Size = New System.Drawing.Size(319, 59)
        Me.txtNOIDUNG.TabIndex = 11
        '
        'numCAUHOI
        '
        Me.numCAUHOI.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bdsBODE, "CAUHOI", True))
        Me.numCAUHOI.Location = New System.Drawing.Point(218, 109)
        Me.numCAUHOI.Name = "numCAUHOI"
        Me.numCAUHOI.Size = New System.Drawing.Size(88, 23)
        Me.numCAUHOI.TabIndex = 9
        '
        'cmbTRINHDO
        '
        Me.cmbTRINHDO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsBODE, "TRINHDO", True))
        Me.cmbTRINHDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTRINHDO.FormattingEnabled = True
        Me.cmbTRINHDO.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbTRINHDO.Location = New System.Drawing.Point(79, 108)
        Me.cmbTRINHDO.Name = "cmbTRINHDO"
        Me.cmbTRINHDO.Size = New System.Drawing.Size(78, 23)
        Me.cmbTRINHDO.TabIndex = 7
        '
        'txtMAGV
        '
        Me.txtMAGV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsBODE, "MAGV", True))
        Me.txtMAGV.Location = New System.Drawing.Point(218, 67)
        Me.txtMAGV.Name = "txtMAGV"
        Me.txtMAGV.ReadOnly = True
        Me.txtMAGV.Size = New System.Drawing.Size(88, 23)
        Me.txtMAGV.TabIndex = 6
        '
        'cmbGV
        '
        Me.cmbGV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHONGIAOVIENBindingSource, "HOTEN", True))
        Me.cmbGV.DataSource = Me.CHONGIAOVIENBindingSource
        Me.cmbGV.DisplayMember = "HOTEN"
        Me.cmbGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGV.FormattingEnabled = True
        Me.cmbGV.Location = New System.Drawing.Point(79, 67)
        Me.cmbGV.Name = "cmbGV"
        Me.cmbGV.Size = New System.Drawing.Size(133, 23)
        Me.cmbGV.TabIndex = 4
        Me.cmbGV.ValueMember = "MAGV"
        '
        'CHONGIAOVIENBindingSource
        '
        Me.CHONGIAOVIENBindingSource.DataMember = "CHONGIAOVIEN"
        Me.CHONGIAOVIENBindingSource.DataSource = Me.DS
        '
        'txtMAMH
        '
        Me.txtMAMH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsBODE, "MAMH", True))
        Me.txtMAMH.Location = New System.Drawing.Point(218, 26)
        Me.txtMAMH.Name = "txtMAMH"
        Me.txtMAMH.ReadOnly = True
        Me.txtMAMH.Size = New System.Drawing.Size(88, 23)
        Me.txtMAMH.TabIndex = 3
        '
        'cmbMH
        '
        Me.cmbMH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHONMONHOCBindingSource, "TENMH", True))
        Me.cmbMH.DataSource = Me.CHONMONHOCBindingSource
        Me.cmbMH.DisplayMember = "TENMH"
        Me.cmbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMH.FormattingEnabled = True
        Me.cmbMH.Location = New System.Drawing.Point(79, 26)
        Me.cmbMH.Name = "cmbMH"
        Me.cmbMH.Size = New System.Drawing.Size(133, 23)
        Me.cmbMH.TabIndex = 1
        Me.cmbMH.ValueMember = "MAMH"
        '
        'CHONGIAOVIENTableAdapter
        '
        Me.CHONGIAOVIENTableAdapter.ClearBeforeFill = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(766, 16)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(89, 44)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnPhuchoi
        '
        Me.btnPhuchoi.Location = New System.Drawing.Point(766, 138)
        Me.btnPhuchoi.Name = "btnPhuchoi"
        Me.btnPhuchoi.Size = New System.Drawing.Size(89, 44)
        Me.btnPhuchoi.TabIndex = 4
        Me.btnPhuchoi.Text = "Phục hồi"
        Me.btnPhuchoi.UseVisualStyleBackColor = True
        '
        'btnGhi
        '
        Me.btnGhi.Location = New System.Drawing.Point(766, 77)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(89, 44)
        Me.btnGhi.TabIndex = 5
        Me.btnGhi.Text = "Ghi"
        Me.btnGhi.UseVisualStyleBackColor = True
        '
        'btnChinhsua
        '
        Me.btnChinhsua.Location = New System.Drawing.Point(766, 199)
        Me.btnChinhsua.Name = "btnChinhsua"
        Me.btnChinhsua.Size = New System.Drawing.Size(89, 44)
        Me.btnChinhsua.TabIndex = 6
        Me.btnChinhsua.Text = "Chỉnh sửa"
        Me.btnChinhsua.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MAMH"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã môn học"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MAGV"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mã giáo viên"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TRINHDO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Trình độ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CAUHOI"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Câu hỏi"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NOIDUNG"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nội dung"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "A"
        Me.DataGridViewTextBoxColumn6.HeaderText = "A"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "B"
        Me.DataGridViewTextBoxColumn7.HeaderText = "B"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "C"
        Me.DataGridViewTextBoxColumn8.HeaderText = "C"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "D"
        Me.DataGridViewTextBoxColumn9.HeaderText = "D"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DAPAN"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Đáp án"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'frmDethi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 490)
        Me.Controls.Add(Me.btnChinhsua)
        Me.Controls.Add(Me.btnGhi)
        Me.Controls.Add(Me.btnPhuchoi)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvBODE)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDethi"
        Me.Text = "frmDethi"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsBODE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBODE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHONMONHOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numCAUHOI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHONGIAOVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS As TRACNGHIEM.DS
    Friend WithEvents bdsBODE As System.Windows.Forms.BindingSource
    Friend WithEvents BODETableAdapter As TRACNGHIEM.DSTableAdapters.BODETableAdapter
    Friend WithEvents dgvBODE As System.Windows.Forms.DataGridView
    Friend WithEvents CHONMONHOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CHONMONHOCTableAdapter As TRACNGHIEM.DSTableAdapters.CHONMONHOCTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMAMH As System.Windows.Forms.TextBox
    Friend WithEvents cmbMH As System.Windows.Forms.ComboBox
    Friend WithEvents CHONGIAOVIENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CHONGIAOVIENTableAdapter As TRACNGHIEM.DSTableAdapters.CHONGIAOVIENTableAdapter
    Friend WithEvents txtNOIDUNG As System.Windows.Forms.TextBox
    Friend WithEvents numCAUHOI As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbTRINHDO As System.Windows.Forms.ComboBox
    Friend WithEvents txtMAGV As System.Windows.Forms.TextBox
    Friend WithEvents cmbGV As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDAPAN As System.Windows.Forms.ComboBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnPhuchoi As System.Windows.Forms.Button
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents btnKetthuc As System.Windows.Forms.Button
    Friend WithEvents btnNhapcauhoi As System.Windows.Forms.Button
    Friend WithEvents btnChinhsua As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
