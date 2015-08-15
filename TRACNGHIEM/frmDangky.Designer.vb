<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangky
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
        Dim HOTENLabel As System.Windows.Forms.Label
        Dim TENLOPLabel As System.Windows.Forms.Label
        Dim TENMHLabel As System.Windows.Forms.Label
        Dim TRINHDOLabel As System.Windows.Forms.Label
        Dim LANLabel As System.Windows.Forms.Label
        Dim SOCAUTHILabel As System.Windows.Forms.Label
        Dim NGAYTHILabel As System.Windows.Forms.Label
        Dim THOIGIANLabel As System.Windows.Forms.Label
        Me.DS = New TRACNGHIEM.DS
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.numTHOIGIAN = New System.Windows.Forms.NumericUpDown
        Me.bdsGIAOVIEN_DANGKY = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpNGAYTHI = New System.Windows.Forms.DateTimePicker
        Me.numSOCAUTHI = New System.Windows.Forms.NumericUpDown
        Me.cmbLAN = New System.Windows.Forms.ComboBox
        Me.cmbTRINHDO = New System.Windows.Forms.ComboBox
        Me.txtMAMH = New System.Windows.Forms.TextBox
        Me.cmbMH = New System.Windows.Forms.ComboBox
        Me.CHONMONHOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtMALOP = New System.Windows.Forms.TextBox
        Me.cmbLOP = New System.Windows.Forms.ComboBox
        Me.CHONLOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtMAGV = New System.Windows.Forms.TextBox
        Me.cmbGV = New System.Windows.Forms.ComboBox
        Me.CHONGIAOVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GIAOVIEN_DANGKYTableAdapter = New TRACNGHIEM.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter
        Me.btnThem = New System.Windows.Forms.Button
        Me.btnPhuchoi = New System.Windows.Forms.Button
        Me.btnGhi = New System.Windows.Forms.Button
        Me.dgvGIAOVIEN_DANGKY = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHONLOPTableAdapter = New TRACNGHIEM.DSTableAdapters.CHONLOPTableAdapter
        Me.CHONMONHOCTableAdapter = New TRACNGHIEM.DSTableAdapters.CHONMONHOCTableAdapter
        Me.CHONGIAOVIENTableAdapter = New TRACNGHIEM.DSTableAdapters.CHONGIAOVIENTableAdapter
        HOTENLabel = New System.Windows.Forms.Label
        TENLOPLabel = New System.Windows.Forms.Label
        TENMHLabel = New System.Windows.Forms.Label
        TRINHDOLabel = New System.Windows.Forms.Label
        LANLabel = New System.Windows.Forms.Label
        SOCAUTHILabel = New System.Windows.Forms.Label
        NGAYTHILabel = New System.Windows.Forms.Label
        THOIGIANLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numTHOIGIAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsGIAOVIEN_DANGKY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSOCAUTHI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHONMONHOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHONLOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHONGIAOVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGIAOVIEN_DANGKY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HOTENLabel
        '
        HOTENLabel.AutoSize = True
        HOTENLabel.Location = New System.Drawing.Point(17, 25)
        HOTENLabel.Name = "HOTENLabel"
        HOTENLabel.Size = New System.Drawing.Size(64, 16)
        HOTENLabel.TabIndex = 0
        HOTENLabel.Text = "Giáo viên:"
        '
        'TENLOPLabel
        '
        TENLOPLabel.AutoSize = True
        TENLOPLabel.Location = New System.Drawing.Point(29, 75)
        TENLOPLabel.Name = "TENLOPLabel"
        TENLOPLabel.Size = New System.Drawing.Size(33, 16)
        TENLOPLabel.TabIndex = 3
        TENLOPLabel.Text = "Lớp:"
        '
        'TENMHLabel
        '
        TENMHLabel.AutoSize = True
        TENMHLabel.Location = New System.Drawing.Point(-3, 117)
        TENMHLabel.Name = "TENMHLabel"
        TENMHLabel.Size = New System.Drawing.Size(87, 16)
        TENMHLabel.TabIndex = 6
        TENMHLabel.Text = "Tên môn học:"
        '
        'TRINHDOLabel
        '
        TRINHDOLabel.AutoSize = True
        TRINHDOLabel.Location = New System.Drawing.Point(11, 160)
        TRINHDOLabel.Name = "TRINHDOLabel"
        TRINHDOLabel.Size = New System.Drawing.Size(61, 16)
        TRINHDOLabel.TabIndex = 9
        TRINHDOLabel.Text = "Trình độ:"
        '
        'LANLabel
        '
        LANLabel.AutoSize = True
        LANLabel.Location = New System.Drawing.Point(174, 160)
        LANLabel.Name = "LANLabel"
        LANLabel.Size = New System.Drawing.Size(50, 16)
        LANLabel.TabIndex = 11
        LANLabel.Text = "Lần thi:"
        '
        'SOCAUTHILabel
        '
        SOCAUTHILabel.AutoSize = True
        SOCAUTHILabel.Location = New System.Drawing.Point(370, 24)
        SOCAUTHILabel.Name = "SOCAUTHILabel"
        SOCAUTHILabel.Size = New System.Drawing.Size(68, 16)
        SOCAUTHILabel.TabIndex = 13
        SOCAUTHILabel.Text = "Số câu thi:"
        '
        'NGAYTHILabel
        '
        NGAYTHILabel.AutoSize = True
        NGAYTHILabel.Location = New System.Drawing.Point(370, 75)
        NGAYTHILabel.Name = "NGAYTHILabel"
        NGAYTHILabel.Size = New System.Drawing.Size(59, 16)
        NGAYTHILabel.TabIndex = 15
        NGAYTHILabel.Text = "Ngày thi:"
        '
        'THOIGIANLabel
        '
        THOIGIANLabel.AutoSize = True
        THOIGIANLabel.Location = New System.Drawing.Point(370, 130)
        THOIGIANLabel.Name = "THOIGIANLabel"
        THOIGIANLabel.Size = New System.Drawing.Size(64, 16)
        THOIGIANLabel.TabIndex = 17
        THOIGIANLabel.Text = "Thời gian:"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(THOIGIANLabel)
        Me.GroupBox1.Controls.Add(Me.numTHOIGIAN)
        Me.GroupBox1.Controls.Add(NGAYTHILabel)
        Me.GroupBox1.Controls.Add(Me.dtpNGAYTHI)
        Me.GroupBox1.Controls.Add(SOCAUTHILabel)
        Me.GroupBox1.Controls.Add(Me.numSOCAUTHI)
        Me.GroupBox1.Controls.Add(LANLabel)
        Me.GroupBox1.Controls.Add(Me.cmbLAN)
        Me.GroupBox1.Controls.Add(TRINHDOLabel)
        Me.GroupBox1.Controls.Add(Me.cmbTRINHDO)
        Me.GroupBox1.Controls.Add(Me.txtMAMH)
        Me.GroupBox1.Controls.Add(TENMHLabel)
        Me.GroupBox1.Controls.Add(Me.cmbMH)
        Me.GroupBox1.Controls.Add(Me.txtMALOP)
        Me.GroupBox1.Controls.Add(TENLOPLabel)
        Me.GroupBox1.Controls.Add(Me.cmbLOP)
        Me.GroupBox1.Controls.Add(Me.txtMAGV)
        Me.GroupBox1.Controls.Add(HOTENLabel)
        Me.GroupBox1.Controls.Add(Me.cmbGV)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 207)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'numTHOIGIAN
        '
        Me.numTHOIGIAN.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bdsGIAOVIEN_DANGKY, "THOIGIAN", True))
        Me.numTHOIGIAN.Location = New System.Drawing.Point(447, 130)
        Me.numTHOIGIAN.Name = "numTHOIGIAN"
        Me.numTHOIGIAN.Size = New System.Drawing.Size(112, 23)
        Me.numTHOIGIAN.TabIndex = 18
        '
        'bdsGIAOVIEN_DANGKY
        '
        Me.bdsGIAOVIEN_DANGKY.DataMember = "GIAOVIEN_DANGKY"
        Me.bdsGIAOVIEN_DANGKY.DataSource = Me.DS
        '
        'dtpNGAYTHI
        '
        Me.dtpNGAYTHI.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bdsGIAOVIEN_DANGKY, "NGAYTHI", True))
        Me.dtpNGAYTHI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNGAYTHI.Location = New System.Drawing.Point(447, 71)
        Me.dtpNGAYTHI.Name = "dtpNGAYTHI"
        Me.dtpNGAYTHI.Size = New System.Drawing.Size(112, 23)
        Me.dtpNGAYTHI.TabIndex = 16
        '
        'numSOCAUTHI
        '
        Me.numSOCAUTHI.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bdsGIAOVIEN_DANGKY, "SOCAUTHI", True))
        Me.numSOCAUTHI.Location = New System.Drawing.Point(444, 22)
        Me.numSOCAUTHI.Name = "numSOCAUTHI"
        Me.numSOCAUTHI.Size = New System.Drawing.Size(58, 23)
        Me.numSOCAUTHI.TabIndex = 14
        '
        'cmbLAN
        '
        Me.cmbLAN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGIAOVIEN_DANGKY, "LAN", True))
        Me.cmbLAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLAN.FormattingEnabled = True
        Me.cmbLAN.Items.AddRange(New Object() {"1", "2"})
        Me.cmbLAN.Location = New System.Drawing.Point(230, 157)
        Me.cmbLAN.Name = "cmbLAN"
        Me.cmbLAN.Size = New System.Drawing.Size(84, 23)
        Me.cmbLAN.TabIndex = 12
        '
        'cmbTRINHDO
        '
        Me.cmbTRINHDO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGIAOVIEN_DANGKY, "TRINHDO", True))
        Me.cmbTRINHDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTRINHDO.FormattingEnabled = True
        Me.cmbTRINHDO.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbTRINHDO.Location = New System.Drawing.Point(90, 157)
        Me.cmbTRINHDO.Name = "cmbTRINHDO"
        Me.cmbTRINHDO.Size = New System.Drawing.Size(68, 23)
        Me.cmbTRINHDO.TabIndex = 10
        '
        'txtMAMH
        '
        Me.txtMAMH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGIAOVIEN_DANGKY, "MAMH", True))
        Me.txtMAMH.Location = New System.Drawing.Point(217, 114)
        Me.txtMAMH.Name = "txtMAMH"
        Me.txtMAMH.ReadOnly = True
        Me.txtMAMH.Size = New System.Drawing.Size(97, 23)
        Me.txtMAMH.TabIndex = 9
        '
        'cmbMH
        '
        Me.cmbMH.DataSource = Me.CHONMONHOCBindingSource
        Me.cmbMH.DisplayMember = "TENMH"
        Me.cmbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMH.FormattingEnabled = True
        Me.cmbMH.Location = New System.Drawing.Point(90, 114)
        Me.cmbMH.Name = "cmbMH"
        Me.cmbMH.Size = New System.Drawing.Size(121, 23)
        Me.cmbMH.TabIndex = 7
        Me.cmbMH.ValueMember = "MAMH"
        '
        'CHONMONHOCBindingSource
        '
        Me.CHONMONHOCBindingSource.DataMember = "CHONMONHOC"
        Me.CHONMONHOCBindingSource.DataSource = Me.DS
        '
        'txtMALOP
        '
        Me.txtMALOP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGIAOVIEN_DANGKY, "MALOP", True))
        Me.txtMALOP.Location = New System.Drawing.Point(217, 68)
        Me.txtMALOP.Name = "txtMALOP"
        Me.txtMALOP.ReadOnly = True
        Me.txtMALOP.Size = New System.Drawing.Size(100, 23)
        Me.txtMALOP.TabIndex = 6
        '
        'cmbLOP
        '
        Me.cmbLOP.DataSource = Me.CHONLOPBindingSource
        Me.cmbLOP.DisplayMember = "TENLOP"
        Me.cmbLOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLOP.FormattingEnabled = True
        Me.cmbLOP.Location = New System.Drawing.Point(90, 68)
        Me.cmbLOP.Name = "cmbLOP"
        Me.cmbLOP.Size = New System.Drawing.Size(121, 23)
        Me.cmbLOP.TabIndex = 4
        Me.cmbLOP.ValueMember = "MALOP"
        '
        'CHONLOPBindingSource
        '
        Me.CHONLOPBindingSource.DataMember = "CHONLOP"
        Me.CHONLOPBindingSource.DataSource = Me.DS
        '
        'txtMAGV
        '
        Me.txtMAGV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGIAOVIEN_DANGKY, "MAGV", True))
        Me.txtMAGV.Location = New System.Drawing.Point(217, 22)
        Me.txtMAGV.Name = "txtMAGV"
        Me.txtMAGV.ReadOnly = True
        Me.txtMAGV.Size = New System.Drawing.Size(100, 23)
        Me.txtMAGV.TabIndex = 3
        '
        'cmbGV
        '
        Me.cmbGV.DataSource = Me.CHONGIAOVIENBindingSource
        Me.cmbGV.DisplayMember = "HOTEN"
        Me.cmbGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGV.FormattingEnabled = True
        Me.cmbGV.Location = New System.Drawing.Point(90, 22)
        Me.cmbGV.Name = "cmbGV"
        Me.cmbGV.Size = New System.Drawing.Size(121, 23)
        Me.cmbGV.TabIndex = 1
        Me.cmbGV.ValueMember = "MAGV"
        '
        'CHONGIAOVIENBindingSource
        '
        Me.CHONGIAOVIENBindingSource.DataMember = "CHONGIAOVIEN"
        Me.CHONGIAOVIENBindingSource.DataSource = Me.DS
        '
        'GIAOVIEN_DANGKYTableAdapter
        '
        Me.GIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(779, 27)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(90, 33)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnPhuchoi
        '
        Me.btnPhuchoi.Location = New System.Drawing.Point(782, 163)
        Me.btnPhuchoi.Name = "btnPhuchoi"
        Me.btnPhuchoi.Size = New System.Drawing.Size(90, 33)
        Me.btnPhuchoi.TabIndex = 4
        Me.btnPhuchoi.Text = "Phục hồi"
        Me.btnPhuchoi.UseVisualStyleBackColor = True
        '
        'btnGhi
        '
        Me.btnGhi.Location = New System.Drawing.Point(779, 95)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(90, 33)
        Me.btnGhi.TabIndex = 5
        Me.btnGhi.Text = "Ghi"
        Me.btnGhi.UseVisualStyleBackColor = True
        '
        'dgvGIAOVIEN_DANGKY
        '
        Me.dgvGIAOVIEN_DANGKY.AutoGenerateColumns = False
        Me.dgvGIAOVIEN_DANGKY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGIAOVIEN_DANGKY.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.dgvGIAOVIEN_DANGKY.DataSource = Me.bdsGIAOVIEN_DANGKY
        Me.dgvGIAOVIEN_DANGKY.Location = New System.Drawing.Point(13, 243)
        Me.dgvGIAOVIEN_DANGKY.Name = "dgvGIAOVIEN_DANGKY"
        Me.dgvGIAOVIEN_DANGKY.Size = New System.Drawing.Size(856, 208)
        Me.dgvGIAOVIEN_DANGKY.TabIndex = 6
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MAGV"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mã giáo viên"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MALOP"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Mã lớp"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "MAMH"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Mã môn học"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TRINHDO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Trình độ"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NGAYTHI"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Ngày thi"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "LAN"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Lần thi"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "SOCAUTHI"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Số câu thi"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "THOIGIAN"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Thời gian"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'CHONLOPTableAdapter
        '
        Me.CHONLOPTableAdapter.ClearBeforeFill = True
        '
        'CHONMONHOCTableAdapter
        '
        Me.CHONMONHOCTableAdapter.ClearBeforeFill = True
        '
        'CHONGIAOVIENTableAdapter
        '
        Me.CHONGIAOVIENTableAdapter.ClearBeforeFill = True
        '
        'frmDangky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 463)
        Me.Controls.Add(Me.dgvGIAOVIEN_DANGKY)
        Me.Controls.Add(Me.btnGhi)
        Me.Controls.Add(Me.btnPhuchoi)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDangky"
        Me.Text = "frmDangky"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numTHOIGIAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsGIAOVIEN_DANGKY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSOCAUTHI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHONMONHOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHONLOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHONGIAOVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGIAOVIEN_DANGKY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS As TRACNGHIEM.DS
    Friend WithEvents GIAOVIEN_DANGKYTableAdapter As TRACNGHIEM.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bdsCHONGIAOVIEN As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMAGV As System.Windows.Forms.TextBox
    Friend WithEvents cmbGV As System.Windows.Forms.ComboBox
    Friend WithEvents bdsLOP As System.Windows.Forms.BindingSource
    Friend WithEvents txtMALOP As System.Windows.Forms.TextBox
    Friend WithEvents cmbLOP As System.Windows.Forms.ComboBox
    Friend WithEvents bdsCHONMONHOC As System.Windows.Forms.BindingSource
    Friend WithEvents txtMAMH As System.Windows.Forms.TextBox
    Friend WithEvents cmbMH As System.Windows.Forms.ComboBox
    Friend WithEvents numSOCAUTHI As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbLAN As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTRINHDO As System.Windows.Forms.ComboBox
    Friend WithEvents dtpNGAYTHI As System.Windows.Forms.DateTimePicker
    Friend WithEvents numTHOIGIAN As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnPhuchoi As System.Windows.Forms.Button
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents bdsGIAOVIEN_DANGKY As System.Windows.Forms.BindingSource
    Friend WithEvents dgvGIAOVIEN_DANGKY As System.Windows.Forms.DataGridView
    Friend WithEvents CHONLOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CHONLOPTableAdapter As TRACNGHIEM.DSTableAdapters.CHONLOPTableAdapter
    Friend WithEvents CHONMONHOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CHONMONHOCTableAdapter As TRACNGHIEM.DSTableAdapters.CHONMONHOCTableAdapter
    Friend WithEvents CHONGIAOVIENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CHONGIAOVIENTableAdapter As TRACNGHIEM.DSTableAdapters.CHONGIAOVIENTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
