Imports System.IO
Imports System.Text

Public Class FormKalkulator
    ' ==================== STRUKTUR DATA ====================
    ' Struktur untuk menyimpan data tanaman
    Private Structure DataTanaman
        Public JenisTanaman As String
        Public UreaPerhektar As Double
        Public NPKPerhektar As Double
        Public TSPPerhektar As Double
        Public KCLPerhektar As Double
        Public PestisidaPerhektar As Double
        Public UmurPanen As Integer
    End Structure

    ' Struktur untuk menyimpan data harga
    Private Structure DataHarga
        Public NamaBahan As String
        Public HargaPerKg As Double
        Public Satuan As String
        Public Kategori As String
    End Structure

    ' Struktur untuk hasil perhitungan
    Private Structure HasilPerhitungan
        Public NamaBahan As String
        Public Kebutuhan As Double
        Public Satuan As String
        Public HargaSatuan As Double
        Public TotalHarga As Double
    End Structure

    ' ==================== VARIABEL GLOBAL ====================
    Private ListTanaman As New List(Of DataTanaman)
    Private ListHarga As New List(Of DataHarga)
    Private ListHasil As New List(Of HasilPerhitungan)

    ' Path file CSV
    Private PathDataTanaman As String = "data_tanaman.csv"
    Private PathHargaPupuk As String = "harga_pupuk.csv"

    ' ==================== EVENT FORM LOAD ====================
    Private Sub FormKalkulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InisialisasiForm()
        MuatDataDariFile()
    End Sub

    ' ==================== PROCEDURE INISIALISASI ====================
    ' Procedure untuk inisialisasi komponen form
    Private Sub InisialisasiForm()
        ' Set properties form
        Me.Text = "Kalkulator Kebutuhan Pupuk & Pestisida"
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Inisialisasi ComboBox Jenis Tanaman
        cboJenisTanaman.DropDownStyle = ComboBoxStyle.DropDownList
        cboJenisTanaman.Items.Clear()

        ' Inisialisasi ComboBox Kondisi Tanah
        cboKondisiTanah.DropDownStyle = ComboBoxStyle.DropDownList
        cboKondisiTanah.Items.Clear()
        cboKondisiTanah.Items.Add("Subur (100%)")
        cboKondisiTanah.Items.Add("Sedang (120%)")
        cboKondisiTanah.Items.Add("Kurang Subur (150%)")
        cboKondisiTanah.SelectedIndex = 0

        ' Set numeric textbox
        txtLuasLahan.Text = "1"

        ' Inisialisasi DataGridView
        IsiKolomDataGrid()

        ' Clear hasil
        lblTotalBiaya.Text = "Rp 0"
        lblInfoTanaman.Text = "Pilih jenis tanaman untuk melihat informasi"
    End Sub

    ' Procedure untuk setup kolom DataGridView
    Private Sub IsiKolomDataGrid()
        dgvHasil.Columns.Clear()
        dgvHasil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Tambah kolom
        dgvHasil.Columns.Add("NamaBahan", "Nama Bahan")
        dgvHasil.Columns.Add("Kebutuhan", "Kebutuhan")
        dgvHasil.Columns.Add("Satuan", "Satuan")
        dgvHasil.Columns.Add("HargaSatuan", "Harga/Satuan")
        dgvHasil.Columns.Add("TotalHarga", "Total Harga")

        ' Set format kolom
        dgvHasil.Columns("Kebutuhan").DefaultCellStyle.Format = "N2"
        dgvHasil.Columns("HargaSatuan").DefaultCellStyle.Format = "N0"
        dgvHasil.Columns("TotalHarga").DefaultCellStyle.Format = "N0"

        ' Set alignment
        dgvHasil.Columns("Kebutuhan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvHasil.Columns("HargaSatuan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvHasil.Columns("TotalHarga").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    ' ==================== PROCEDURE BACA FILE (KRITERIA: MEMBACA FILE) ====================
    ' Procedure untuk membaca semua file data
    Private Sub MuatDataDariFile()
        Try
            ' Baca data tanaman
            BacaDataTanaman(PathDataTanaman)

            ' Baca data harga
            BacaDataHarga(PathHargaPupuk)

            ' Update ComboBox
            UpdateComboBoxTanaman()

            MessageBox.Show("Data berhasil dimuat dari file CSV!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saat membaca file: " & ex.Message & vbCrLf & vbCrLf & "Pastikan file data_tanaman.csv dan harga_pupuk.csv ada di folder yang sama dengan aplikasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Procedure untuk membaca file data tanaman (MENGGUNAKAN PERULANGAN)
    Private Sub BacaDataTanaman(namaFile As String)
        ListTanaman.Clear()

        ' Cek apakah file ada
        If Not File.Exists(namaFile) Then
            Throw New FileNotFoundException("File " & namaFile & " tidak ditemukan!")
        End If

        Dim lines() As String = File.ReadAllLines(namaFile)

        ' PERULANGAN untuk membaca setiap baris file
        For i As Integer = 1 To lines.Length - 1 ' Mulai dari 1 untuk skip header
            Dim data() As String = lines(i).Split(","c)

            ' PERCABANGAN untuk validasi data
            If data.Length >= 7 Then
                Dim tanaman As DataTanaman

                tanaman.JenisTanaman = data(0).Trim()
                tanaman.UreaPerhektar = Convert.ToDouble(data(1))
                tanaman.NPKPerhektar = Convert.ToDouble(data(2))
                tanaman.TSPPerhektar = Convert.ToDouble(data(3))
                tanaman.KCLPerhektar = Convert.ToDouble(data(4))
                tanaman.PestisidaPerhektar = Convert.ToDouble(data(5))
                tanaman.UmurPanen = Convert.ToInt32(data(6))

                ListTanaman.Add(tanaman)
            End If
        Next
    End Sub

    ' Procedure untuk membaca file data harga (MENGGUNAKAN PERULANGAN)
    Private Sub BacaDataHarga(namaFile As String)
        ListHarga.Clear()

        ' Cek apakah file ada
        If Not File.Exists(namaFile) Then
            Throw New FileNotFoundException("File " & namaFile & " tidak ditemukan!")
        End If

        Dim lines() As String = File.ReadAllLines(namaFile)

        ' PERULANGAN untuk membaca setiap baris
        For i As Integer = 1 To lines.Length - 1
            Dim data() As String = lines(i).Split(","c)

            ' PERCABANGAN untuk validasi
            If data.Length >= 4 Then
                Dim harga As DataHarga

                harga.NamaBahan = data(0).Trim()
                harga.HargaPerKg = Convert.ToDouble(data(1))
                harga.Satuan = data(2).Trim()
                harga.Kategori = data(3).Trim()

                ListHarga.Add(harga)
            End If
        Next
    End Sub

    ' Procedure untuk update ComboBox tanaman
    Private Sub UpdateComboBoxTanaman()
        cboJenisTanaman.Items.Clear()

        ' PERULANGAN untuk isi combobox
        For Each tanaman As DataTanaman In ListTanaman
            cboJenisTanaman.Items.Add(tanaman.JenisTanaman)
        Next

        ' Set default selection
        If cboJenisTanaman.Items.Count > 0 Then
            cboJenisTanaman.SelectedIndex = 0
        End If
    End Sub

    ' ==================== EVENT COMBOBOX CHANGED ====================
    Private Sub cboJenisTanaman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJenisTanaman.SelectedIndexChanged
        TampilkanInfoTanaman()
    End Sub

    ' Procedure untuk menampilkan informasi tanaman
    Private Sub TampilkanInfoTanaman()
        ' PERCABANGAN untuk cek apakah ada yang dipilih
        If cboJenisTanaman.SelectedIndex >= 0 Then
            Dim namaTanaman As String = cboJenisTanaman.SelectedItem.ToString()
            Dim tanaman As DataTanaman = Nothing

            ' PERULANGAN untuk cari data tanaman
            For Each t As DataTanaman In ListTanaman
                If t.JenisTanaman = namaTanaman Then
                    tanaman = t
                    Exit For
                End If
            Next

            ' Tampilkan info
            Dim info As New StringBuilder()
            info.AppendLine("INFORMASI TANAMAN")
            info.AppendLine("═══════════════════════")
            info.AppendLine("Jenis: " & tanaman.JenisTanaman)
            info.AppendLine("Umur Panen: " & tanaman.UmurPanen & " hari")
            info.AppendLine("")
            info.AppendLine("KEBUTUHAN PER HEKTAR:")
            info.AppendLine("• Urea: " & tanaman.UreaPerhektar & " Kg")
            info.AppendLine("• NPK: " & tanaman.NPKPerhektar & " Kg")
            info.AppendLine("• TSP: " & tanaman.TSPPerhektar & " Kg")
            info.AppendLine("• KCL: " & tanaman.KCLPerhektar & " Kg")
            info.AppendLine("• Pestisida: " & tanaman.PestisidaPerhektar & " Liter")

            lblInfoTanaman.Text = info.ToString()
        End If
    End Sub

    ' ==================== BUTTON HITUNG (KRITERIA: PERCABANGAN & PERULANGAN) ====================
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        ' PERCABANGAN untuk validasi input
        If Not ValidasiInput() Then
            Return
        End If

        ' Ambil data input
        Dim namaTanaman As String = cboJenisTanaman.SelectedItem.ToString()
        Dim luasLahan As Double = Convert.ToDouble(txtLuasLahan.Text)
        Dim faktorKondisi As Double = GetFaktorKondisiTanah()

        ' Cari data tanaman
        Dim tanaman As DataTanaman = Nothing
        For Each t As DataTanaman In ListTanaman
            If t.JenisTanaman = namaTanaman Then
                tanaman = t
                Exit For
            End If
        Next

        ' Hitung kebutuhan
        HitungKebutuhan(tanaman, luasLahan, faktorKondisi)

        ' Tampilkan hasil
        TampilkanHasilKeGrid()

        ' Hitung total biaya
        HitungTotalBiaya()
    End Sub

    ' Function untuk validasi input (MENGGUNAKAN PERCABANGAN)
    Private Function ValidasiInput() As Boolean
        ' PERCABANGAN: Cek jenis tanaman
        If cboJenisTanaman.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih jenis tanaman!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboJenisTanaman.Focus()
            Return False
        End If

        ' PERCABANGAN: Cek luas lahan
        If String.IsNullOrWhiteSpace(txtLuasLahan.Text) Then
            MessageBox.Show("Silakan isi luas lahan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLuasLahan.Focus()
            Return False
        End If

        Dim luas As Double
        ' PERCABANGAN: Cek format angka
        If Not Double.TryParse(txtLuasLahan.Text, luas) OrElse luas <= 0 Then
            MessageBox.Show("Luas lahan harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLuasLahan.Focus()
            Return False
        End If

        ' PERCABANGAN: Cek kondisi tanah
        If cboKondisiTanah.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih kondisi tanah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboKondisiTanah.Focus()
            Return False
        End If

        Return True
    End Function

    ' Function untuk mendapatkan faktor kondisi tanah (MENGGUNAKAN PERCABANGAN)
    Private Function GetFaktorKondisiTanah() As Double
        ' PERCABANGAN untuk tentukan faktor berdasarkan kondisi tanah
        Select Case cboKondisiTanah.SelectedIndex
            Case 0 ' Subur
                Return 1.0
            Case 1 ' Sedang
                Return 1.2
            Case 2 ' Kurang Subur
                Return 1.5
            Case Else
                Return 1.0
        End Select
    End Function

    ' Procedure untuk menghitung kebutuhan (MENGGUNAKAN PERULANGAN)
    Private Sub HitungKebutuhan(tanaman As DataTanaman, luasLahan As Double, faktorKondisi As Double)
        ListHasil.Clear()

        ' Array nama pupuk untuk perulangan
        Dim namaPupuk() As String = {"Urea", "NPK", "TSP", "KCL"}
        Dim kebutuhanPupuk() As Double = {
            tanaman.UreaPerhektar * luasLahan * faktorKondisi,
            tanaman.NPKPerhektar * luasLahan * faktorKondisi,
            tanaman.TSPPerhektar * luasLahan * faktorKondisi,
            tanaman.KCLPerhektar * luasLahan * faktorKondisi
        }

        ' PERULANGAN untuk hitung setiap pupuk
        For i As Integer = 0 To namaPupuk.Length - 1
            Dim hasil As HasilPerhitungan
            hasil.NamaBahan = namaPupuk(i)
            hasil.Kebutuhan = kebutuhanPupuk(i)
            hasil.Satuan = "Kg"

            ' Cari harga - PERULANGAN
            For Each harga As DataHarga In ListHarga
                If harga.NamaBahan = namaPupuk(i) Then
                    hasil.HargaSatuan = harga.HargaPerKg
                    Exit For
                End If
            Next

            hasil.TotalHarga = hasil.Kebutuhan * hasil.HargaSatuan
            ListHasil.Add(hasil)
        Next

        ' Hitung pestisida
        Dim hasilPestisida As HasilPerhitungan
        hasilPestisida.NamaBahan = "Pestisida (Rata-rata)"
        hasilPestisida.Kebutuhan = tanaman.PestisidaPerhektar * luasLahan * faktorKondisi
        hasilPestisida.Satuan = "Liter"

        ' Hitung rata-rata harga pestisida - PERULANGAN
        Dim totalHargaPestisida As Double = 0
        Dim jumlahPestisida As Integer = 0

        For Each harga As DataHarga In ListHarga
            ' PERCABANGAN untuk filter kategori pestisida
            If harga.Kategori = "Pestisida" Then
                totalHargaPestisida += harga.HargaPerKg
                jumlahPestisida += 1
            End If
        Next

        ' PERCABANGAN untuk cegah division by zero
        If jumlahPestisida > 0 Then
            hasilPestisida.HargaSatuan = totalHargaPestisida / jumlahPestisida
        Else
            hasilPestisida.HargaSatuan = 0
        End If

        hasilPestisida.TotalHarga = hasilPestisida.Kebutuhan * hasilPestisida.HargaSatuan
        ListHasil.Add(hasilPestisida)
    End Sub

    ' Procedure untuk tampilkan hasil ke DataGridView (MENGGUNAKAN PERULANGAN)
    Private Sub TampilkanHasilKeGrid()
        dgvHasil.Rows.Clear()

        ' PERULANGAN untuk tampilkan setiap hasil
        For Each hasil As HasilPerhitungan In ListHasil
            dgvHasil.Rows.Add(
                hasil.NamaBahan,
                hasil.Kebutuhan,
                hasil.Satuan,
                hasil.HargaSatuan,
                hasil.TotalHarga
            )
        Next

        ' Warna header
        dgvHasil.EnableHeadersVisualStyles = False
        dgvHasil.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80)
        dgvHasil.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvHasil.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
    End Sub

    ' Procedure untuk hitung total biaya (MENGGUNAKAN PERULANGAN)
    Private Sub HitungTotalBiaya()
        Dim total As Double = 0

        ' PERULANGAN untuk jumlahkan semua biaya
        For Each hasil As HasilPerhitungan In ListHasil
            total += hasil.TotalHarga
        Next

        lblTotalBiaya.Text = "Rp " & total.ToString("N0")
    End Sub

    ' ==================== BUTTON RESET ====================
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset semua input
        txtLuasLahan.Text = "1"
        cboKondisiTanah.SelectedIndex = 0

        If cboJenisTanaman.Items.Count > 0 Then
            cboJenisTanaman.SelectedIndex = 0
        End If

        ' Clear hasil
        dgvHasil.Rows.Clear()
        lblTotalBiaya.Text = "Rp 0"
        ListHasil.Clear()
    End Sub

    ' ==================== BUTTON SIMPAN (KRITERIA: MENULIS FILE) ====================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' PERCABANGAN: Cek apakah ada hasil yang akan disimpan
        If ListHasil.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk disimpan! Silakan hitung terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
            saveDialog.FileName = "Hasil_Perhitungan_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"

            ' PERCABANGAN: Cek apakah user klik OK
            If saveDialog.ShowDialog() = DialogResult.OK Then
                SimpanHasilKeFile(saveDialog.FileName)
                MessageBox.Show("Data berhasil disimpan ke: " & vbCrLf & saveDialog.FileName, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error saat menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Procedure untuk menyimpan hasil ke file (MENGGUNAKAN PERULANGAN)
    Private Sub SimpanHasilKeFile(namaFile As String)
        Dim sb As New StringBuilder()

        ' Header informasi
        sb.AppendLine("LAPORAN PERHITUNGAN KEBUTUHAN PUPUK & PESTISIDA")
        sb.AppendLine("Tanggal: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
        sb.AppendLine("Jenis Tanaman: " & cboJenisTanaman.SelectedItem.ToString())
        sb.AppendLine("Luas Lahan: " & txtLuasLahan.Text & " Hektar")
        sb.AppendLine("Kondisi Tanah: " & cboKondisiTanah.SelectedItem.ToString())
        sb.AppendLine("")

        ' Header tabel
        sb.AppendLine("Nama Bahan,Kebutuhan,Satuan,Harga Satuan,Total Harga")

        ' PERULANGAN untuk tulis data
        For Each hasil As HasilPerhitungan In ListHasil
            sb.AppendLine(String.Format("{0},{1:N2},{2},{3:N0},{4:N0}",
                hasil.NamaBahan,
                hasil.Kebutuhan,
                hasil.Satuan,
                hasil.HargaSatuan,
                hasil.TotalHarga))
        Next

        ' Total
        Dim total As Double = 0
        For Each hasil As HasilPerhitungan In ListHasil
            total += hasil.TotalHarga
        Next

        sb.AppendLine("")
        sb.AppendLine("TOTAL BIAYA,,,," & total.ToString("N0"))

        ' Tulis ke file
        File.WriteAllText(namaFile, sb.ToString())
    End Sub

    ' ==================== BUTTON CETAK ====================
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' PERCABANGAN: Validasi ada data untuk dicetak
        If ListHasil.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk dicetak! Silakan hitung terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        CetakLaporan()
    End Sub

    ' Procedure untuk cetak laporan (menggunakan PrintPreviewDialog)
    Private Sub CetakLaporan()
        Try
            Dim printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintPage

            Dim preview As New PrintPreviewDialog()
            preview.Document = printDoc
            preview.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error saat mencetak: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler untuk print page
    Private Sub PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim font As New Font("Arial", 10)
        Dim fontBold As New Font("Arial", 10, FontStyle.Bold)
        Dim fontTitle As New Font("Arial", 14, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)

        Dim y As Integer = 50
        Dim lineHeight As Integer = 20

        ' Title
        e.Graphics.DrawString("LAPORAN PERHITUNGAN PUPUK & PESTISIDA", fontTitle, brush, 100, y)
        y += lineHeight * 2

        ' Info
        e.Graphics.DrawString("Tanggal: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), font, brush, 100, y)
        y += lineHeight
        e.Graphics.DrawString("Jenis Tanaman: " & cboJenisTanaman.SelectedItem.ToString(), font, brush, 100, y)
        y += lineHeight
        e.Graphics.DrawString("Luas Lahan: " & txtLuasLahan.Text & " Hektar", font, brush, 100, y)
        y += lineHeight
        e.Graphics.DrawString("Kondisi Tanah: " & cboKondisiTanah.SelectedItem.ToString(), font, brush, 100, y)
        y += lineHeight * 2

        ' Header tabel
        e.Graphics.DrawString("Nama Bahan", fontBold, brush, 100, y)
        e.Graphics.DrawString("Kebutuhan", fontBold, brush, 300, y)
        e.Graphics.DrawString("Satuan", fontBold, brush, 450, y)
        e.Graphics.DrawString("Harga", fontBold, brush, 550, y)
        e.Graphics.DrawString("Total", fontBold, brush, 650, y)
        y += lineHeight

        ' Garis
        e.Graphics.DrawLine(Pens.Black, 100, y, 750, y)
        y += 5

        ' PERULANGAN: Data
        For Each hasil As HasilPerhitungan In ListHasil
            e.Graphics.DrawString(hasil.NamaBahan, font, brush, 100, y)
            e.Graphics.DrawString(hasil.Kebutuhan.ToString("N2"), font, brush, 300, y)
            e.Graphics.DrawString(hasil.Satuan, font, brush, 450, y)
            e.Graphics.DrawString("Rp " & hasil.HargaSatuan.ToString("N0"), font, brush, 550, y)
            e.Graphics.DrawString("Rp " & hasil.TotalHarga.ToString("N0"), font, brush, 650, y)
            y += lineHeight
        Next

        ' Garis
        y += 5
        e.Graphics.DrawLine(Pens.Black, 100, y, 750, y)
        y += lineHeight

        ' Total
        Dim total As Double = 0
        For Each hasil As HasilPerhitungan In ListHasil
            total += hasil.TotalHarga
        Next

        e.Graphics.DrawString("TOTAL BIAYA:", fontBold, brush, 550, y)
        e.Graphics.DrawString("Rp " & total.ToString("N0"), fontBold, brush, 650, y)
    End Sub

    ' ==================== BUTTON BACA FILE ====================
    Private Sub btnBacaFile_Click(sender As Object, e As EventArgs) Handles btnBacaFile.Click
        Try
            Dim openDialog As New OpenFileDialog()
            openDialog.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt"
            openDialog.Title = "Pilih File Data"

            If openDialog.ShowDialog() = DialogResult.OK Then
                ' Cek nama file untuk tentukan jenis data
                If openDialog.FileName.ToLower().Contains("tanaman") Then
                    BacaDataTanaman(openDialog.FileName)
                    UpdateComboBoxTanaman()
                    MessageBox.Show("Data tanaman berhasil dimuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf openDialog.FileName.ToLower().Contains("harga") OrElse openDialog.FileName.ToLower().Contains("pupuk") Then
                    BacaDataHarga(openDialog.FileName)
                    MessageBox.Show("Data harga berhasil dimuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Format file tidak dikenali. Pastikan nama file mengandung 'tanaman' atau 'harga'.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error saat membaca file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ==================== BUTTON KELUAR ====================
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        ' PERCABANGAN: Konfirmasi keluar
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' ==================== VALIDASI INPUT NUMERIC ====================
    Private Sub txtLuasLahan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLuasLahan.KeyPress
        ' PERCABANGAN: Hanya izinkan angka, backspace, dan titik desimal
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If

        ' PERCABANGAN: Cegah lebih dari satu titik desimal
        If e.KeyChar = "."c AndAlso txtLuasLahan.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

End Class
