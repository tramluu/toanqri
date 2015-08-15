<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonhoc
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
        Dim MAMHLabel As System.Windows.Forms.Label
        Dim TENMHLabel As System.Windows.Forms.Label
        Me.DS = New TRACNGHIEM.DS
        Me.bdsMH = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvMH = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtMAMH = New System.Windows.Forms.TextBox
        Me.txtTENMH = New System.Windows.Forms.TextBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daMH = New System.Data.SqlClient.SqlDataAdapter
        Me.btnThem = New System.Windows.Forms.Button
        Me.btnHieuchinh = New System.Windows.Forms.Button
        Me.btnGhi = New System.Windows.Forms.Button
        Me.btnTim = New System.Windows.Forms.Button
        Me.btnXoa = New System.Windows.Forms.Button
        Me.btnPhuchoi = New System.Windows.Forms.Button
        MAMHLabel = New System.Windows.Forms.Label
        TENMHLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsMH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MAMHLabel
        '
        MAMHLabel.AutoSize = True
        MAMHLabel.Location = New System.Drawing.Point(19, 352)
        MAMHLabel.Name = "MAMHLabel"
        MAMHLabel.Size = New System.Drawing.Size(83, 16)
        MAMHLabel.TabIndex = 1
        MAMHLabel.Text = "Mã môn học:"
        '
        'TENMHLabel
        '
        TENMHLabel.AutoSize = True
        TENMHLabel.Location = New System.Drawing.Point(276, 352)
        TENMHLabel.Name = "TENMHLabel"
        TENMHLabel.Size = New System.Drawing.Size(87, 16)
        TENMHLabel.TabIndex = 3
        TENMHLabel.Text = "Tên môn học:"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bdsMH
        '
        Me.bdsMH.DataMember = "Monhoc"
        Me.bdsMH.DataSource = Me.DS
        '
        'dgvMH
        '
        Me.dgvMH.AutoGenerateColumns = False
        Me.dgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMH.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvMH.DataSource = Me.bdsMH
        Me.dgvMH.Location = New System.Drawing.Point(22, 24)
        Me.dgvMH.Name = "dgvMH"
        Me.dgvMH.Size = New System.Drawing.Size(541, 256)
        Me.dgvMH.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MAMH"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã môn học"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TENMH"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tên môn học"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'txtMAMH
        '
        Me.txtMAMH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsMH, "MAMH", True))
        Me.txtMAMH.Location = New System.Drawing.Point(102, 350)
        Me.txtMAMH.MaxLength = 5
        Me.txtMAMH.Name = "txtMAMH"
        Me.txtMAMH.Size = New System.Drawing.Size(106, 23)
        Me.txtMAMH.TabIndex = 2
        '
        'txtTENMH
        '
        Me.txtTENMH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsMH, "TENMH", True))
        Me.txtTENMH.Location = New System.Drawing.Point(364, 350)
        Me.txtTENMH.MaxLength = 40
        Me.txtTENMH.Name = "txtTENMH"
        Me.txtTENMH.Size = New System.Drawing.Size(199, 23)
        Me.txtTENMH.TabIndex = 4
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        TENMH, MAMH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Monhoc"
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
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Monhoc] ([TENMH], [MAMH]) VALUES (@TENMH, @MAMH);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT TENMH, MAM" & _
            "H FROM Monhoc WHERE (MAMH = @MAMH)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TENMH", System.Data.SqlDbType.VarChar, 0, "TENMH"), New System.Data.SqlClient.SqlParameter("@MAMH", System.Data.SqlDbType.[Char], 0, "MAMH")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE [Monhoc] SET [TENMH] = @TENMH, [MAMH] = @MAMH WHERE (([TENMH] = @Original_" & _
            "TENMH) AND ([MAMH] = @Original_MAMH));" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT TENMH, MAMH FROM Monhoc WHERE (MA" & _
            "MH = @MAMH)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TENMH", System.Data.SqlDbType.VarChar, 0, "TENMH"), New System.Data.SqlClient.SqlParameter("@MAMH", System.Data.SqlDbType.[Char], 0, "MAMH"), New System.Data.SqlClient.SqlParameter("@Original_TENMH", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TENMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MAMH", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAMH", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Monhoc] WHERE (([TENMH] = @Original_TENMH) AND ([MAMH] = @Original_M" & _
            "AMH))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_TENMH", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TENMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MAMH", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAMH", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daMH
        '
        Me.daMH.DeleteCommand = Me.SqlDeleteCommand1
        Me.daMH.InsertCommand = Me.SqlInsertCommand1
        Me.daMH.SelectCommand = Me.SqlSelectCommand1
        Me.daMH.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Monhoc", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TENMH", "TENMH"), New System.Data.Common.DataColumnMapping("MAMH", "MAMH")})})
        Me.daMH.UpdateCommand = Me.SqlUpdateCommand1
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(617, 24)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(124, 41)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnHieuchinh
        '
        Me.btnHieuchinh.Location = New System.Drawing.Point(617, 92)
        Me.btnHieuchinh.Name = "btnHieuchinh"
        Me.btnHieuchinh.Size = New System.Drawing.Size(124, 41)
        Me.btnHieuchinh.TabIndex = 6
        Me.btnHieuchinh.Text = "Hiệu chỉnh"
        Me.btnHieuchinh.UseVisualStyleBackColor = True
        '
        'btnGhi
        '
        Me.btnGhi.Location = New System.Drawing.Point(617, 159)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(124, 41)
        Me.btnGhi.TabIndex = 7
        Me.btnGhi.Text = "Ghi"
        Me.btnGhi.UseVisualStyleBackColor = True
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(617, 227)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(124, 41)
        Me.btnTim.TabIndex = 8
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(617, 294)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(124, 41)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnPhuchoi
        '
        Me.btnPhuchoi.Location = New System.Drawing.Point(617, 362)
        Me.btnPhuchoi.Name = "btnPhuchoi"
        Me.btnPhuchoi.Size = New System.Drawing.Size(124, 41)
        Me.btnPhuchoi.TabIndex = 10
        Me.btnPhuchoi.Text = "Phục hồi"
        Me.btnPhuchoi.UseVisualStyleBackColor = True
        '
        'frmMonhoc
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
        Me.Controls.Add(TENMHLabel)
        Me.Controls.Add(Me.txtTENMH)
        Me.Controls.Add(MAMHLabel)
        Me.Controls.Add(Me.txtMAMH)
        Me.Controls.Add(Me.dgvMH)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMonhoc"
        Me.Text = "frmMonhoc"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsMH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As TRACNGHIEM.DS
    Friend WithEvents bdsMH As System.Windows.Forms.BindingSource
    Friend WithEvents dgvMH As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMAMH As System.Windows.Forms.TextBox
    Friend WithEvents txtTENMH As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daMH As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnHieuchinh As System.Windows.Forms.Button
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnPhuchoi As System.Windows.Forms.Button
End Class
