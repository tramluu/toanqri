<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiaovien
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
        Dim MAGVLabel As System.Windows.Forms.Label
        Dim HOLabel As System.Windows.Forms.Label
        Dim TENLabel As System.Windows.Forms.Label
        Dim SODTLLLabel As System.Windows.Forms.Label
        Dim DIACHILabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGiaovien))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daGV = New System.Data.SqlClient.SqlDataAdapter
        Me.dgvGV = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bdsGV = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New TRACNGHIEM.DS
        Me.txtMAGV = New System.Windows.Forms.TextBox
        Me.txtHO = New System.Windows.Forms.TextBox
        Me.txtTEN = New System.Windows.Forms.TextBox
        Me.txtSODTLL = New System.Windows.Forms.TextBox
        Me.txtDIACHI = New System.Windows.Forms.TextBox
        Me.btnThem = New System.Windows.Forms.Button
        Me.btnHieuchinh = New System.Windows.Forms.Button
        Me.btnGhi = New System.Windows.Forms.Button
        Me.btnTim = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.GiaovienTableAdapter = New TRACNGHIEM.DSTableAdapters.GiaovienTableAdapter
        Me.btnPhuchoi = New System.Windows.Forms.Button
        MAGVLabel = New System.Windows.Forms.Label
        HOLabel = New System.Windows.Forms.Label
        TENLabel = New System.Windows.Forms.Label
        SODTLLLabel = New System.Windows.Forms.Label
        DIACHILabel = New System.Windows.Forms.Label
        CType(Me.dgvGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MAGVLabel
        '
        MAGVLabel.AutoSize = True
        MAGVLabel.Location = New System.Drawing.Point(40, 286)
        MAGVLabel.Name = "MAGVLabel"
        MAGVLabel.Size = New System.Drawing.Size(80, 16)
        MAGVLabel.TabIndex = 1
        MAGVLabel.Text = "Mã giáo viên"
        '
        'HOLabel
        '
        HOLabel.AutoSize = True
        HOLabel.Location = New System.Drawing.Point(60, 332)
        HOLabel.Name = "HOLabel"
        HOLabel.Size = New System.Drawing.Size(24, 16)
        HOLabel.TabIndex = 3
        HOLabel.Text = "Họ"
        '
        'TENLabel
        '
        TENLabel.AutoSize = True
        TENLabel.Location = New System.Drawing.Point(52, 378)
        TENLabel.Name = "TENLabel"
        TENLabel.Size = New System.Drawing.Size(30, 16)
        TENLabel.TabIndex = 5
        TENLabel.Text = "Tên"
        '
        'SODTLLLabel
        '
        SODTLLLabel.AutoSize = True
        SODTLLLabel.Location = New System.Drawing.Point(355, 329)
        SODTLLLabel.Name = "SODTLLLabel"
        SODTLLLabel.Size = New System.Drawing.Size(89, 16)
        SODTLLLabel.TabIndex = 7
        SODTLLLabel.Text = "Số ĐT liên lạc"
        '
        'DIACHILabel
        '
        DIACHILabel.AutoSize = True
        DIACHILabel.Location = New System.Drawing.Point(370, 378)
        DIACHILabel.Name = "DIACHILabel"
        DIACHILabel.Size = New System.Drawing.Size(48, 16)
        DIACHILabel.TabIndex = 9
        DIACHILabel.Text = "Địa chỉ"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        MAGV, HO, TEN, SODTLL, DIACHI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Giaovien"
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
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Giaovien] ([MAGV], [HO], [TEN], [SODTLL], [DIACHI]) VALUES (@MAGV, @" & _
            "HO, @TEN, @SODTLL, @DIACHI);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT MAGV, HO, TEN, SODTLL, DIACHI FROM Giaovien" & _
            " WHERE (MAGV = @MAGV)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MAGV", System.Data.SqlDbType.[Char], 0, "MAGV"), New System.Data.SqlClient.SqlParameter("@HO", System.Data.SqlDbType.VarChar, 0, "HO"), New System.Data.SqlClient.SqlParameter("@TEN", System.Data.SqlDbType.VarChar, 0, "TEN"), New System.Data.SqlClient.SqlParameter("@SODTLL", System.Data.SqlDbType.[Char], 0, "SODTLL"), New System.Data.SqlClient.SqlParameter("@DIACHI", System.Data.SqlDbType.VarChar, 0, "DIACHI")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MAGV", System.Data.SqlDbType.[Char], 0, "MAGV"), New System.Data.SqlClient.SqlParameter("@HO", System.Data.SqlDbType.VarChar, 0, "HO"), New System.Data.SqlClient.SqlParameter("@TEN", System.Data.SqlDbType.VarChar, 0, "TEN"), New System.Data.SqlClient.SqlParameter("@SODTLL", System.Data.SqlDbType.[Char], 0, "SODTLL"), New System.Data.SqlClient.SqlParameter("@DIACHI", System.Data.SqlDbType.VarChar, 0, "DIACHI"), New System.Data.SqlClient.SqlParameter("@Original_MAGV", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAGV", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HO", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TEN", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TEN", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SODTLL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SODTLL", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SODTLL", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SODTLL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DIACHI", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DIACHI", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DIACHI", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DIACHI", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_MAGV", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAGV", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HO", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TEN", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TEN", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SODTLL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SODTLL", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SODTLL", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SODTLL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DIACHI", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DIACHI", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DIACHI", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DIACHI", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daGV
        '
        Me.daGV.DeleteCommand = Me.SqlDeleteCommand1
        Me.daGV.InsertCommand = Me.SqlInsertCommand1
        Me.daGV.SelectCommand = Me.SqlSelectCommand1
        Me.daGV.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Giaovien", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MAGV", "MAGV"), New System.Data.Common.DataColumnMapping("HO", "HO"), New System.Data.Common.DataColumnMapping("TEN", "TEN"), New System.Data.Common.DataColumnMapping("SODTLL", "SODTLL"), New System.Data.Common.DataColumnMapping("DIACHI", "DIACHI")})})
        Me.daGV.UpdateCommand = Me.SqlUpdateCommand1
        '
        'dgvGV
        '
        Me.dgvGV.AutoGenerateColumns = False
        Me.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvGV.DataSource = Me.bdsGV
        Me.dgvGV.Location = New System.Drawing.Point(12, 12)
        Me.dgvGV.Name = "dgvGV"
        Me.dgvGV.Size = New System.Drawing.Size(671, 247)
        Me.dgvGV.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MAGV"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã giáo viên"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "HO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Họ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TEN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tên"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SODTLL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Số ĐT liên lạc"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DIACHI"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Địa chỉ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'bdsGV
        '
        Me.bdsGV.DataMember = "Giaovien"
        Me.bdsGV.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtMAGV
        '
        Me.txtMAGV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGV, "MAGV", True))
        Me.txtMAGV.Location = New System.Drawing.Point(141, 283)
        Me.txtMAGV.Name = "txtMAGV"
        Me.txtMAGV.Size = New System.Drawing.Size(100, 23)
        Me.txtMAGV.TabIndex = 2
        '
        'txtHO
        '
        Me.txtHO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGV, "HO", True))
        Me.txtHO.Location = New System.Drawing.Point(141, 326)
        Me.txtHO.Name = "txtHO"
        Me.txtHO.Size = New System.Drawing.Size(100, 23)
        Me.txtHO.TabIndex = 4
        '
        'txtTEN
        '
        Me.txtTEN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGV, "TEN", True))
        Me.txtTEN.Location = New System.Drawing.Point(141, 371)
        Me.txtTEN.Name = "txtTEN"
        Me.txtTEN.Size = New System.Drawing.Size(100, 23)
        Me.txtTEN.TabIndex = 6
        '
        'txtSODTLL
        '
        Me.txtSODTLL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGV, "SODTLL", True))
        Me.txtSODTLL.Location = New System.Drawing.Point(450, 325)
        Me.txtSODTLL.Name = "txtSODTLL"
        Me.txtSODTLL.Size = New System.Drawing.Size(100, 23)
        Me.txtSODTLL.TabIndex = 8
        '
        'txtDIACHI
        '
        Me.txtDIACHI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsGV, "DIACHI", True))
        Me.txtDIACHI.Location = New System.Drawing.Point(450, 375)
        Me.txtDIACHI.Name = "txtDIACHI"
        Me.txtDIACHI.Size = New System.Drawing.Size(100, 23)
        Me.txtDIACHI.TabIndex = 10
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(740, 12)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(108, 42)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnHieuchinh
        '
        Me.btnHieuchinh.Location = New System.Drawing.Point(740, 82)
        Me.btnHieuchinh.Name = "btnHieuchinh"
        Me.btnHieuchinh.Size = New System.Drawing.Size(108, 42)
        Me.btnHieuchinh.TabIndex = 12
        Me.btnHieuchinh.Text = "Hiệu chỉnh"
        Me.btnHieuchinh.UseVisualStyleBackColor = True
        '
        'btnGhi
        '
        Me.btnGhi.Location = New System.Drawing.Point(740, 151)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(108, 42)
        Me.btnGhi.TabIndex = 13
        Me.btnGhi.Text = "Ghi"
        Me.btnGhi.UseVisualStyleBackColor = True
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(740, 226)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(108, 42)
        Me.btnTim.TabIndex = 14
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(740, 303)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(108, 42)
        Me.btnXoa.TabIndex = 15
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'GiaovienTableAdapter
        '
        Me.GiaovienTableAdapter.ClearBeforeFill = True
        '
        'btnPhuchoi
        '
        Me.btnPhuchoi.Location = New System.Drawing.Point(740, 375)
        Me.btnPhuchoi.Name = "btnPhuchoi"
        Me.btnPhuchoi.Size = New System.Drawing.Size(108, 45)
        Me.btnPhuchoi.TabIndex = 16
        Me.btnPhuchoi.Text = "Phục hồi"
        Me.btnPhuchoi.UseVisualStyleBackColor = True
        '
        'frmGiaovien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.btnPhuchoi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnTim)
        Me.Controls.Add(Me.btnGhi)
        Me.Controls.Add(Me.btnHieuchinh)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(DIACHILabel)
        Me.Controls.Add(Me.txtDIACHI)
        Me.Controls.Add(SODTLLLabel)
        Me.Controls.Add(Me.txtSODTLL)
        Me.Controls.Add(TENLabel)
        Me.Controls.Add(Me.txtTEN)
        Me.Controls.Add(HOLabel)
        Me.Controls.Add(Me.txtHO)
        Me.Controls.Add(MAGVLabel)
        Me.Controls.Add(Me.txtMAGV)
        Me.Controls.Add(Me.dgvGV)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGiaovien"
        Me.Text = "frmGiaovien"
        CType(Me.dgvGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daGV As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DS As TRACNGHIEM.DS
    Friend WithEvents bdsGV As System.Windows.Forms.BindingSource
    Friend WithEvents GiaovienTableAdapter As TRACNGHIEM.DSTableAdapters.GiaovienTableAdapter
    Friend WithEvents dgvGV As System.Windows.Forms.DataGridView
    Friend WithEvents txtMAGV As System.Windows.Forms.TextBox
    Friend WithEvents txtHO As System.Windows.Forms.TextBox
    Friend WithEvents txtTEN As System.Windows.Forms.TextBox
    Friend WithEvents txtSODTLL As System.Windows.Forms.TextBox
    Friend WithEvents txtDIACHI As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnHieuchinh As System.Windows.Forms.Button
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnPhuchoi As System.Windows.Forms.Button
End Class
