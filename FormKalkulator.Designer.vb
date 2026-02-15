<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKalkulator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.lblJenisTanaman = New System.Windows.Forms.Label()
        Me.cboJenisTanaman = New System.Windows.Forms.ComboBox()
        Me.lblLuasLahan = New System.Windows.Forms.Label()
        Me.txtLuasLahan = New System.Windows.Forms.TextBox()
        Me.lblHektar = New System.Windows.Forms.Label()
        Me.lblKondisiTanah = New System.Windows.Forms.Label()
        Me.cboKondisiTanah = New System.Windows.Forms.ComboBox()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.lblInfoTanaman = New System.Windows.Forms.Label()
        Me.grpHasil = New System.Windows.Forms.GroupBox()
        Me.dgvHasil = New System.Windows.Forms.DataGridView()
        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTotalBiaya = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnBacaFile = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.grpHasil.SuspendLayout()
        CType(Me.dgvHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotal.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1100, 80)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(485, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "🌾 KALKULATOR PUPUK && PESTISIDA"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.White
        Me.lblSubtitle.Location = New System.Drawing.Point(20, 50)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(380, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Sistem Perhitungan Kebutuhan Pupuk dan Pestisida Pertanian"
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.lblJenisTanaman)
        Me.grpInput.Controls.Add(Me.cboJenisTanaman)
        Me.grpInput.Controls.Add(Me.lblLuasLahan)
        Me.grpInput.Controls.Add(Me.txtLuasLahan)
        Me.grpInput.Controls.Add(Me.lblHektar)
        Me.grpInput.Controls.Add(Me.lblKondisiTanah)
        Me.grpInput.Controls.Add(Me.cboKondisiTanah)
        Me.grpInput.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.grpInput.Location = New System.Drawing.Point(20, 100)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(520, 180)
        Me.grpInput.TabIndex = 1
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "📋 DATA LAHAN && TANAMAN"
        '
        'lblJenisTanaman
        '
        Me.lblJenisTanaman.AutoSize = True
        Me.lblJenisTanaman.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJenisTanaman.ForeColor = System.Drawing.Color.Black
        Me.lblJenisTanaman.Location = New System.Drawing.Point(20, 35)
        Me.lblJenisTanaman.Name = "lblJenisTanaman"
        Me.lblJenisTanaman.Size = New System.Drawing.Size(103, 17)
        Me.lblJenisTanaman.TabIndex = 0
        Me.lblJenisTanaman.Text = "Jenis Tanaman:"
        '
        'cboJenisTanaman
        '
        Me.cboJenisTanaman.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboJenisTanaman.FormattingEnabled = True
        Me.cboJenisTanaman.Location = New System.Drawing.Point(150, 32)
        Me.cboJenisTanaman.Name = "cboJenisTanaman"
        Me.cboJenisTanaman.Size = New System.Drawing.Size(340, 25)
        Me.cboJenisTanaman.TabIndex = 1
        '
        'lblLuasLahan
        '
        Me.lblLuasLahan.AutoSize = True
        Me.lblLuasLahan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLuasLahan.ForeColor = System.Drawing.Color.Black
        Me.lblLuasLahan.Location = New System.Drawing.Point(20, 80)
        Me.lblLuasLahan.Name = "lblLuasLahan"
        Me.lblLuasLahan.Size = New System.Drawing.Size(81, 17)
        Me.lblLuasLahan.TabIndex = 2
        Me.lblLuasLahan.Text = "Luas Lahan:"
        '
        'txtLuasLahan
        '
        Me.txtLuasLahan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLuasLahan.Location = New System.Drawing.Point(150, 77)
        Me.txtLuasLahan.Name = "txtLuasLahan"
        Me.txtLuasLahan.Size = New System.Drawing.Size(250, 25)
        Me.txtLuasLahan.TabIndex = 3
        Me.txtLuasLahan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHektar
        '
        Me.lblHektar.AutoSize = True
        Me.lblHektar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHektar.ForeColor = System.Drawing.Color.Black
        Me.lblHektar.Location = New System.Drawing.Point(410, 80)
        Me.lblHektar.Name = "lblHektar"
        Me.lblHektar.Size = New System.Drawing.Size(25, 17)
        Me.lblHektar.TabIndex = 4
        Me.lblHektar.Text = "Ha"
        '
        'lblKondisiTanah
        '
        Me.lblKondisiTanah.AutoSize = True
        Me.lblKondisiTanah.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblKondisiTanah.ForeColor = System.Drawing.Color.Black
        Me.lblKondisiTanah.Location = New System.Drawing.Point(20, 125)
        Me.lblKondisiTanah.Name = "lblKondisiTanah"
        Me.lblKondisiTanah.Size = New System.Drawing.Size(94, 17)
        Me.lblKondisiTanah.TabIndex = 5
        Me.lblKondisiTanah.Text = "Kondisi Tanah:"
        '
        'cboKondisiTanah
        '
        Me.cboKondisiTanah.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboKondisiTanah.FormattingEnabled = True
        Me.cboKondisiTanah.Location = New System.Drawing.Point(150, 122)
        Me.cboKondisiTanah.Name = "cboKondisiTanah"
        Me.cboKondisiTanah.Size = New System.Drawing.Size(340, 25)
        Me.cboKondisiTanah.TabIndex = 6
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.lblInfoTanaman)
        Me.grpInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.grpInfo.Location = New System.Drawing.Point(560, 100)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(520, 180)
        Me.grpInfo.TabIndex = 2
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "ℹ️ INFORMASI TANAMAN"
        '
        'lblInfoTanaman
        '
        Me.lblInfoTanaman.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInfoTanaman.ForeColor = System.Drawing.Color.Black
        Me.lblInfoTanaman.Location = New System.Drawing.Point(15, 30)
        Me.lblInfoTanaman.Name = "lblInfoTanaman"
        Me.lblInfoTanaman.Size = New System.Drawing.Size(490, 140)
        Me.lblInfoTanaman.TabIndex = 0
        Me.lblInfoTanaman.Text = "Pilih jenis tanaman untuk melihat informasi"
        '
        'grpHasil
        '
        Me.grpHasil.Controls.Add(Me.dgvHasil)
        Me.grpHasil.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpHasil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.grpHasil.Location = New System.Drawing.Point(20, 300)
        Me.grpHasil.Name = "grpHasil"
        Me.grpHasil.Size = New System.Drawing.Size(1060, 280)
        Me.grpHasil.TabIndex = 3
        Me.grpHasil.TabStop = False
        Me.grpHasil.Text = "💰 HASIL PERHITUNGAN KEBUTUHAN"
        '
        'dgvHasil
        '
        Me.dgvHasil.AllowUserToAddRows = False
        Me.dgvHasil.AllowUserToDeleteRows = False
        Me.dgvHasil.BackgroundColor = System.Drawing.Color.White
        Me.dgvHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHasil.Location = New System.Drawing.Point(15, 30)
        Me.dgvHasil.Name = "dgvHasil"
        Me.dgvHasil.ReadOnly = True
        Me.dgvHasil.RowTemplate.Height = 25
        Me.dgvHasil.Size = New System.Drawing.Size(1030, 235)
        Me.dgvHasil.TabIndex = 0
        '
        'pnlTotal
        '
        Me.pnlTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotal.Controls.Add(Me.lblTotalLabel)
        Me.pnlTotal.Controls.Add(Me.lblTotalBiaya)
        Me.pnlTotal.Location = New System.Drawing.Point(20, 600)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(1060, 60)
        Me.pnlTotal.TabIndex = 4
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblTotalLabel.Location = New System.Drawing.Point(690, 15)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(137, 25)
        Me.lblTotalLabel.TabIndex = 0
        Me.lblTotalLabel.Text = "TOTAL BIAYA:"
        '
        'lblTotalBiaya
        '
        Me.lblTotalBiaya.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalBiaya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblTotalBiaya.Location = New System.Drawing.Point(835, 12)
        Me.lblTotalBiaya.Name = "lblTotalBiaya"
        Me.lblTotalBiaya.Size = New System.Drawing.Size(200, 30)
        Me.lblTotalBiaya.TabIndex = 1
        Me.lblTotalBiaya.Text = "Rp 0"
        Me.lblTotalBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnBacaFile)
        Me.pnlButtons.Controls.Add(Me.btnHitung)
        Me.pnlButtons.Controls.Add(Me.btnSimpan)
        Me.pnlButtons.Controls.Add(Me.btnCetak)
        Me.pnlButtons.Controls.Add(Me.btnReset)
        Me.pnlButtons.Controls.Add(Me.btnKeluar)
        Me.pnlButtons.Location = New System.Drawing.Point(20, 680)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1060, 60)
        Me.pnlButtons.TabIndex = 5
        '
        'btnBacaFile
        '
        Me.btnBacaFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnBacaFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBacaFile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBacaFile.ForeColor = System.Drawing.Color.White
        Me.btnBacaFile.Location = New System.Drawing.Point(10, 10)
        Me.btnBacaFile.Name = "btnBacaFile"
        Me.btnBacaFile.Size = New System.Drawing.Size(160, 40)
        Me.btnBacaFile.TabIndex = 0
        Me.btnBacaFile.Text = "📂 Baca File"
        Me.btnBacaFile.UseVisualStyleBackColor = False
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHitung.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHitung.ForeColor = System.Drawing.Color.White
        Me.btnHitung.Location = New System.Drawing.Point(190, 10)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(160, 40)
        Me.btnHitung.TabIndex = 1
        Me.btnHitung.Text = "🧮 Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(370, 10)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(160, 40)
        Me.btnSimpan.TabIndex = 2
        Me.btnSimpan.Text = "💾 Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Location = New System.Drawing.Point(550, 10)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(160, 40)
        Me.btnCetak.TabIndex = 3
        Me.btnCetak.Text = "📄 Cetak"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(730, 10)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 40)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "🔄 Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(910, 10)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(140, 40)
        Me.btnKeluar.TabIndex = 5
        Me.btnKeluar.Text = "❌ Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'FormKalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 760)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlTotal)
        Me.Controls.Add(Me.grpHasil)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormKalkulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kalkulator Pupuk & Pestisida"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpHasil.ResumeLayout(False)
        CType(Me.dgvHasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlTotal.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents lblJenisTanaman As Label
    Friend WithEvents cboJenisTanaman As ComboBox
    Friend WithEvents lblLuasLahan As Label
    Friend WithEvents txtLuasLahan As TextBox
    Friend WithEvents lblHektar As Label
    Friend WithEvents lblKondisiTanah As Label
    Friend WithEvents cboKondisiTanah As ComboBox
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents lblInfoTanaman As Label
    Friend WithEvents grpHasil As GroupBox
    Friend WithEvents dgvHasil As DataGridView
    Friend WithEvents pnlTotal As Panel
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblTotalBiaya As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnBacaFile As Button
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnKeluar As Button
End Class
