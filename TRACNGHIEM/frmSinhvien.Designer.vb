<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSinhvien
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
        Dim MALOPLabel As System.Windows.Forms.Label
        Dim TENLOPLabel As System.Windows.Forms.Label
        Dim HOLabel As System.Windows.Forms.Label
        Dim MASVLabel As System.Windows.Forms.Label
        Dim TENLabel As System.Windows.Forms.Label
        Dim NGAYSINHLabel As System.Windows.Forms.Label
        Dim DIACHILabel As System.Windows.Forms.Label
        Dim MALOPLabel1 As System.Windows.Forms.Label
        Me.btnTim = New System.Windows.Forms.Button
        Me.btnHieuchinh = New System.Windows.Forms.Button
        Me.btnGhi = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.btnPhuchoi = New System.Windows.Forms.Button
        Me.btnThem = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daLOP = New System.Data.SqlClient.SqlDataAdapter
        Me.dgvLOP = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bdsLOP = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New TRACNGHIEM.DS
        Me.txtMALOP = New System.Windows.Forms.TextBox
        Me.txtTENLOP = New System.Windows.Forms.TextBox
        Me.bdsSV = New System.Windows.Forms.BindingSource(Me.components)
        Me.SinhvienTableAdapter = New TRACNGHIEM.DSTableAdapters.SinhvienTableAdapter
        Me.dgvSV = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.txtHO = New System.Windows.Forms.TextBox
        Me.txtMASV = New System.Windows.Forms.TextBox
        Me.txtTEN = New System.Windows.Forms.TextBox
        Me.dtpNGAYSINH = New System.Windows.Forms.DateTimePicker
        Me.txtDIACHI = New System.Windows.Forms.TextBox
        Me.cmbMALOP = New System.Windows.Forms.ComboBox
        MALOPLabel = New System.Windows.Forms.Label
        TENLOPLabel = New System.Windows.Forms.Label
        HOLabel = New System.Windows.Forms.Label
        MASVLabel = New System.Windows.Forms.Label
        TENLabel = New System.Windows.Forms.Label
        NGAYSINHLabel = New System.Windows.Forms.Label
        DIACHILabel = New System.Windows.Forms.Label
        MALOPLabel1 = New System.Windows.Forms.Label
        CType(Me.dgvLOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsLOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MALOPLabel
        '
        MALOPLabel.AutoSize = True
        MALOPLabel.Location = New System.Drawing.Point(507, 30)
        MALOPLabel.Name = "MALOPLabel"
        MALOPLabel.Size = New System.Drawing.Size(50, 16)
        MALOPLabel.TabIndex = 30
        MALOPLabel.Text = "Mã lớp:"
        '
        'TENLOPLabel
        '
        TENLOPLabel.AutoSize = True
        TENLOPLabel.Location = New System.Drawing.Point(501, 71)
        TENLOPLabel.Name = "TENLOPLabel"
        TENLOPLabel.Size = New System.Drawing.Size(54, 16)
        TENLOPLabel.TabIndex = 31
        TENLOPLabel.Text = "Tên lớp:"
        '
        'HOLabel
        '
        HOLabel.AutoSize = True
        HOLabel.Location = New System.Drawing.Point(269, 385)
        HOLabel.Name = "HOLabel"
        HOLabel.Size = New System.Drawing.Size(27, 16)
        HOLabel.TabIndex = 32
        HOLabel.Text = "Họ:"
        '
        'MASVLabel
        '
        MASVLabel.AutoSize = True
        MASVLabel.Location = New System.Drawing.Point(21, 385)
        MASVLabel.Name = "MASVLabel"
        MASVLabel.Size = New System.Drawing.Size(83, 16)
        MASVLabel.TabIndex = 33
        MASVLabel.Text = "Mã sinh viên:"
        '
        'TENLabel
        '
        TENLabel.AutoSize = True
        TENLabel.Location = New System.Drawing.Point(470, 388)
        TENLabel.Name = "TENLabel"
        TENLabel.Size = New System.Drawing.Size(33, 16)
        TENLabel.TabIndex = 34
        TENLabel.Text = "Tên:"
        '
        'NGAYSINHLabel
        '
        NGAYSINHLabel.AutoSize = True
        NGAYSINHLabel.Location = New System.Drawing.Point(80, 448)
        NGAYSINHLabel.Name = "NGAYSINHLabel"
        NGAYSINHLabel.Size = New System.Drawing.Size(68, 16)
        NGAYSINHLabel.TabIndex = 35
        NGAYSINHLabel.Text = "Ngày sinh:"
        '
        'DIACHILabel
        '
        DIACHILabel.AutoSize = True
        DIACHILabel.Location = New System.Drawing.Point(68, 505)
        DIACHILabel.Name = "DIACHILabel"
        DIACHILabel.Size = New System.Drawing.Size(51, 16)
        DIACHILabel.TabIndex = 36
        DIACHILabel.Text = "Địa chỉ:"
        '
        'MALOPLabel1
        '
        MALOPLabel1.AutoSize = True
        MALOPLabel1.Location = New System.Drawing.Point(470, 505)
        MALOPLabel1.Name = "MALOPLabel1"
        MALOPLabel1.Size = New System.Drawing.Size(33, 16)
        MALOPLabel1.TabIndex = 37
        MALOPLabel1.Text = "Lớp:"
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(736, 291)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(130, 50)
        Me.btnTim.TabIndex = 29
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnHieuchinh
        '
        Me.btnHieuchinh.Location = New System.Drawing.Point(736, 105)
        Me.btnHieuchinh.Name = "btnHieuchinh"
        Me.btnHieuchinh.Size = New System.Drawing.Size(130, 50)
        Me.btnHieuchinh.TabIndex = 28
        Me.btnHieuchinh.Text = "Hiệu chỉnh"
        Me.btnHieuchinh.UseVisualStyleBackColor = True
        '
        'btnGhi
        '
        Me.btnGhi.Location = New System.Drawing.Point(736, 198)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(130, 50)
        Me.btnGhi.TabIndex = 27
        Me.btnGhi.Text = "Ghi"
        Me.btnGhi.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(736, 384)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(130, 50)
        Me.btnXoa.TabIndex = 26
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnPhuchoi
        '
        Me.btnPhuchoi.Location = New System.Drawing.Point(736, 477)
        Me.btnPhuchoi.Name = "btnPhuchoi"
        Me.btnPhuchoi.Size = New System.Drawing.Size(130, 50)
        Me.btnPhuchoi.TabIndex = 25
        Me.btnPhuchoi.Text = "Phục hồi"
        Me.btnPhuchoi.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(736, 12)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(130, 50)
        Me.btnThem.TabIndex = 24
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        MALOP, TENLOP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Lop"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=PC;Initial Catalog=TRAC_NGHIEM;Persist Security Info=True;User ID=sa;" & _
            "Password=tram"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Lop] ([MALOP], [TENLOP]) VALUES (@MALOP, @TENLOP);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT MALOP, TE" & _
            "NLOP FROM Lop WHERE (MALOP = @MALOP)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MALOP", System.Data.SqlDbType.[Char], 0, "MALOP"), New System.Data.SqlClient.SqlParameter("@TENLOP", System.Data.SqlDbType.VarChar, 0, "TENLOP")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE [Lop] SET [MALOP] = @MALOP, [TENLOP] = @TENLOP WHERE (([MALOP] = @Original" & _
            "_MALOP) AND ([TENLOP] = @Original_TENLOP));" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT MALOP, TENLOP FROM Lop WHERE" & _
            " (MALOP = @MALOP)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MALOP", System.Data.SqlDbType.[Char], 0, "MALOP"), New System.Data.SqlClient.SqlParameter("@TENLOP", System.Data.SqlDbType.VarChar, 0, "TENLOP"), New System.Data.SqlClient.SqlParameter("@Original_MALOP", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MALOP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TENLOP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TENLOP", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Lop] WHERE (([MALOP] = @Original_MALOP) AND ([TENLOP] = @Original_TE" & _
            "NLOP))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_MALOP", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MALOP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TENLOP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TENLOP", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daLOP
        '
        Me.daLOP.DeleteCommand = Me.SqlDeleteCommand1
        Me.daLOP.InsertCommand = Me.SqlInsertCommand1
        Me.daLOP.SelectCommand = Me.SqlSelectCommand1
        Me.daLOP.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lop", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MALOP", "MALOP"), New System.Data.Common.DataColumnMapping("TENLOP", "TENLOP")})})
        Me.daLOP.UpdateCommand = Me.SqlUpdateCommand1
        '
        'dgvLOP
        '
        Me.dgvLOP.AutoGenerateColumns = False
        Me.dgvLOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLOP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvLOP.DataSource = Me.bdsLOP
        Me.dgvLOP.Location = New System.Drawing.Point(24, 12)
        Me.dgvLOP.Name = "dgvLOP"
        Me.dgvLOP.Size = New System.Drawing.Size(444, 102)
        Me.dgvLOP.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MALOP"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã lớp"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TENLOP"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tên lớp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'bdsLOP
        '
        Me.bdsLOP.DataMember = "Lop"
        Me.bdsLOP.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtMALOP
        '
        Me.txtMALOP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsLOP, "MALOP", True))
        Me.txtMALOP.Location = New System.Drawing.Point(571, 27)
        Me.txtMALOP.Name = "txtMALOP"
        Me.txtMALOP.Size = New System.Drawing.Size(100, 23)
        Me.txtMALOP.TabIndex = 31
        '
        'txtTENLOP
        '
        Me.txtTENLOP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsLOP, "TENLOP", True))
        Me.txtTENLOP.Location = New System.Drawing.Point(571, 68)
        Me.txtTENLOP.Name = "txtTENLOP"
        Me.txtTENLOP.Size = New System.Drawing.Size(100, 23)
        Me.txtTENLOP.TabIndex = 32
        '
        'bdsSV
        '
        Me.bdsSV.DataMember = "LOP_Sinhvien"
        Me.bdsSV.DataSource = Me.bdsLOP
        '
        'SinhvienTableAdapter
        '
        Me.SinhvienTableAdapter.ClearBeforeFill = True
        '
        'dgvSV
        '
        Me.dgvSV.AutoGenerateColumns = False
        Me.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgvSV.DataSource = Me.bdsSV
        Me.dgvSV.Location = New System.Drawing.Point(24, 137)
        Me.dgvSV.Name = "dgvSV"
        Me.dgvSV.Size = New System.Drawing.Size(676, 208)
        Me.dgvSV.TabIndex = 32
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Họ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MASV"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mã sinh viên"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TEN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tên"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NGAYSINH"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DIACHI"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Địa chỉ"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MALOP"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.bdsLOP
        Me.DataGridViewTextBoxColumn8.DisplayMember = "TENLOP"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tên lớp"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "MALOP"
        '
        'txtHO
        '
        Me.txtHO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsSV, "HO", True))
        Me.txtHO.Location = New System.Drawing.Point(311, 382)
        Me.txtHO.Name = "txtHO"
        Me.txtHO.Size = New System.Drawing.Size(100, 23)
        Me.txtHO.TabIndex = 33
        '
        'txtMASV
        '
        Me.txtMASV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsSV, "MASV", True))
        Me.txtMASV.Location = New System.Drawing.Point(110, 382)
        Me.txtMASV.Name = "txtMASV"
        Me.txtMASV.Size = New System.Drawing.Size(118, 23)
        Me.txtMASV.TabIndex = 34
        '
        'txtTEN
        '
        Me.txtTEN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsSV, "TEN", True))
        Me.txtTEN.Location = New System.Drawing.Point(520, 382)
        Me.txtTEN.Name = "txtTEN"
        Me.txtTEN.Size = New System.Drawing.Size(135, 23)
        Me.txtTEN.TabIndex = 35
        '
        'dtpNGAYSINH
        '
        Me.dtpNGAYSINH.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bdsSV, "NGAYSINH", True))
        Me.dtpNGAYSINH.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNGAYSINH.Location = New System.Drawing.Point(168, 442)
        Me.dtpNGAYSINH.Name = "dtpNGAYSINH"
        Me.dtpNGAYSINH.Size = New System.Drawing.Size(269, 23)
        Me.dtpNGAYSINH.TabIndex = 36
        '
        'txtDIACHI
        '
        Me.txtDIACHI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsSV, "DIACHI", True))
        Me.txtDIACHI.Location = New System.Drawing.Point(132, 502)
        Me.txtDIACHI.Name = "txtDIACHI"
        Me.txtDIACHI.Size = New System.Drawing.Size(288, 23)
        Me.txtDIACHI.TabIndex = 37
        '
        'cmbMALOP
        '
        Me.cmbMALOP.DataSource = Me.bdsLOP
        Me.cmbMALOP.DisplayMember = "TENLOP"
        Me.cmbMALOP.FormattingEnabled = True
        Me.cmbMALOP.Location = New System.Drawing.Point(534, 502)
        Me.cmbMALOP.Name = "cmbMALOP"
        Me.cmbMALOP.Size = New System.Drawing.Size(151, 23)
        Me.cmbMALOP.TabIndex = 38
        Me.cmbMALOP.ValueMember = "MALOP"
        '
        'frmSinhvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 557)
        Me.Controls.Add(MALOPLabel1)
        Me.Controls.Add(Me.cmbMALOP)
        Me.Controls.Add(DIACHILabel)
        Me.Controls.Add(Me.txtDIACHI)
        Me.Controls.Add(NGAYSINHLabel)
        Me.Controls.Add(Me.dtpNGAYSINH)
        Me.Controls.Add(TENLabel)
        Me.Controls.Add(Me.txtTEN)
        Me.Controls.Add(MASVLabel)
        Me.Controls.Add(Me.txtMASV)
        Me.Controls.Add(HOLabel)
        Me.Controls.Add(Me.txtHO)
        Me.Controls.Add(Me.dgvSV)
        Me.Controls.Add(TENLOPLabel)
        Me.Controls.Add(Me.txtTENLOP)
        Me.Controls.Add(MALOPLabel)
        Me.Controls.Add(Me.txtMALOP)
        Me.Controls.Add(Me.dgvLOP)
        Me.Controls.Add(Me.btnTim)
        Me.Controls.Add(Me.btnHieuchinh)
        Me.Controls.Add(Me.btnGhi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnPhuchoi)
        Me.Controls.Add(Me.btnThem)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSinhvien"
        Me.Text = "frmSinhvien"
        CType(Me.dgvLOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsLOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnHieuchinh As System.Windows.Forms.Button
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnPhuchoi As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daLOP As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DS As TRACNGHIEM.DS
    Friend WithEvents bdsLOP As System.Windows.Forms.BindingSource
    Friend WithEvents dgvLOP As System.Windows.Forms.DataGridView
    Friend WithEvents txtMALOP As System.Windows.Forms.TextBox
    Friend WithEvents txtTENLOP As System.Windows.Forms.TextBox
    Friend WithEvents bdsSV As System.Windows.Forms.BindingSource
    Friend WithEvents SinhvienTableAdapter As TRACNGHIEM.DSTableAdapters.SinhvienTableAdapter
    Friend WithEvents dgvSV As System.Windows.Forms.DataGridView
    Friend WithEvents txtHO As System.Windows.Forms.TextBox
    Friend WithEvents txtMASV As System.Windows.Forms.TextBox
    Friend WithEvents txtTEN As System.Windows.Forms.TextBox
    Friend WithEvents dtpNGAYSINH As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDIACHI As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbMALOP As System.Windows.Forms.ComboBox
End Class
