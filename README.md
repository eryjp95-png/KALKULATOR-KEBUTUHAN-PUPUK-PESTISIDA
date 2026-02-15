# 🌾 Kalkulator Kebutuhan Pupuk & Pestisida

**Aplikasi Desktop untuk Perhitungan Kebutuhan Pupuk dan Pestisida Pertanian**

Sistem manajemen pertanian yang membantu petani menghitung kebutuhan pupuk dan pestisida secara akurat berdasarkan jenis tanaman, luas lahan, dan kondisi tanah.

---

## 📋 Daftar Isi
- [Fitur Utama](#-fitur-utama)
- [Kriteria Program](#-kriteria-program)
- [Screenshot](#-screenshot)
- [Instalasi](#-instalasi)
- [Cara Penggunaan](#-cara-penggunaan)
- [Struktur File](#-struktur-file)
- [Database CSV](#-database-csv)

---

## ✨ Fitur Utama

### 🧮 Perhitungan Cerdas
- ✅ Perhitungan otomatis kebutuhan 4 jenis pupuk (Urea, NPK, TSP, KCL)
- ✅ Estimasi kebutuhan pestisida
- ✅ Penyesuaian berdasarkan kondisi tanah (Subur/Sedang/Kurang Subur)
- ✅ Kalkulasi total biaya produksi

### 📊 Manajemen Data
- ✅ Database 7 jenis tanaman populer
- ✅ Import data dari file CSV
- ✅ Update harga pupuk secara fleksibel
- ✅ Informasi detail per tanaman (kebutuhan & umur panen)

### 💾 Output & Laporan
- ✅ Export hasil ke CSV
- ✅ Print preview laporan
- ✅ Format laporan profesional
- ✅ Riwayat perhitungan

---

## 🎯 Kriteria Program

Program ini memenuhi **SEMUA kriteria** yang dipersyaratkan:

| Kriteria | Status | Implementasi |
|----------|--------|--------------|
| **Membaca File** | ✅ | Baca `data_tanaman.csv` dan `harga_pupuk.csv` |
| **Percabangan** | ✅ | Validasi input, Select Case kondisi tanah, If-Else filtering |
| **Perulangan** | ✅ | For loop membaca file, For Each display data |
| **Procedure** | ✅ | 20+ procedures untuk modularitas code |

### Detail Implementasi:

#### 1️⃣ Membaca File
```vb
Private Sub BacaDataTanaman(namaFile As String)
    Dim lines() As String = File.ReadAllLines(namaFile)
    For i As Integer = 1 To lines.Length - 1
        ' Process CSV data
    Next
End Sub
```

#### 2️⃣ Percabangan
```vb
' Validasi Input
If cboJenisTanaman.SelectedIndex = -1 Then
    MessageBox.Show("Silakan pilih jenis tanaman!")
    Return False
End If

' Select Case untuk kondisi tanah
Select Case cboKondisiTanah.SelectedIndex
    Case 0: Return 1.0  ' Subur
    Case 1: Return 1.2  ' Sedang
    Case 2: Return 1.5  ' Kurang Subur
End Select
```

#### 3️⃣ Perulangan
```vb
' Loop untuk hitung semua pupuk
For i As Integer = 0 To namaPupuk.Length - 1
    Dim hasil As HasilPerhitungan
    hasil.Kebutuhan = kebutuhanPupuk(i)
    ListHasil.Add(hasil)
Next

' Loop untuk display ke grid
For Each hasil As HasilPerhitungan In ListHasil
    dgvHasil.Rows.Add(hasil...)
Next
```

#### 4️⃣ Procedure
```vb
' Procedure Inisialisasi
Private Sub InisialisasiForm()
Private Sub IsiKolomDataGrid()

' Procedure I/O File
Private Sub BacaDataTanaman(namaFile As String)
Private Sub BacaDataHarga(namaFile As String)
Private Sub SimpanHasilKeFile(namaFile As String)

' Procedure Perhitungan
Private Sub HitungKebutuhan(...)
Private Sub HitungTotalBiaya()

' Procedure Display
Private Sub TampilkanHasilKeGrid()
Private Sub TampilkanInfoTanaman()
```



### Tampilan Utama
```
┌──────────────────────────────────────────────────────────┐
│  🌾 KALKULATOR PUPUK & PESTISIDA                         │
│  Sistem Perhitungan Kebutuhan Pupuk dan Pestisida       │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  📋 DATA LAHAN & TANAMAN    │  ℹ️ INFORMASI TANAMAN     │
│  ┌────────────────────────┐ │  ┌──────────────────────┐ │
│  │ Jenis: [Padi       ▼]  │ │  │ INFORMASI TANAMAN    │ │
│  │ Luas:  [2.5      ] Ha  │ │  │ ══════════════════   │ │
│  │ Tanah: [Sedang     ▼]  │ │  │ Jenis: Padi          │ │
│  └────────────────────────┘ │  │ Umur: 120 hari       │ │
│                              │  │                      │ │
│  💰 HASIL PERHITUNGAN        │  │ KEBUTUHAN/HEKTAR:    │ │
│  ┌──────────────────────────┴──┤ • Urea: 200 Kg       │ │
│  │ Nama     │ Jml  │ Satuan │ │ • NPK: 150 Kg        │ │
│  ├──────────┼──────┼────────┤ │ • TSP: 100 Kg        │ │
│  │ Urea     │ 600  │ Kg     │ │ • KCL: 50 Kg         │ │
│  │ NPK      │ 450  │ Kg     │ │ • Pestisida: 2 L     │ │
│  │ TSP      │ 300  │ Kg     │ └──────────────────────┘ │
│  │ KCL      │ 150  │ Kg     │                          │
│  │ Pestisida│ 6    │ Liter  │                          │
│  └──────────┴──────┴────────┘                          │
│                                                          │
│  TOTAL BIAYA: Rp 4,850,000                               │
│                                                          │
│  [📂 Baca] [🧮 Hitung] [💾 Simpan] [📄 Cetak]          │
│  [🔄 Reset] [❌ Keluar]                                 │
└──────────────────────────────────────────────────────────┘
```

---

## 🚀 Instalasi

### Persyaratan Sistem
- Windows 7/8/10/11
- .NET Framework 4.7.2 atau lebih tinggi
- Visual Studio 2019 atau lebih baru (untuk development)

### Langkah Instalasi

1. **Clone Repository**
```bash
git clone https://github.com/username/kalkulator-pupuk.git
cd kalkulator-pupuk
```

2. **Buka di Visual Studio**
   - Buka Visual Studio
   - File → Open → Project/Solution
   - Pilih file `.sln`

3. **Build Project**
   - Build → Build Solution (Ctrl+Shift+B)

4. **Run Aplikasi**
   - Debug → Start Debugging (F5)

### Instalasi Database
Pastikan file CSV ada di folder yang sama dengan executable:
```
📁 bin/Debug/
  ├── KalkulatorPupuk.exe
  ├── data_tanaman.csv
  └── harga_pupuk.csv
```

---

## 📖 Cara Penggunaan

### 1. Input Data
1. Pilih jenis tanaman dari dropdown
2. Masukkan luas lahan (dalam hektar)
3. Pilih kondisi tanah

### 2. Hitung Kebutuhan
1. Klik tombol "🧮 Hitung"
2. Hasil akan muncul di tabel
3. Total biaya ditampilkan di bawah

### 3. Simpan/Cetak
- **Simpan**: Klik "💾 Simpan" → Pilih lokasi → Save
- **Cetak**: Klik "📄 Cetak" → Preview → Print

### 4. Import Data Baru
1. Klik "📂 Baca File"
2. Pilih file CSV
3. Data akan ter-update otomatis

---

## 📁 Struktur File

```
KalkulatorPupuk/
│
├── FormKalkulator.vb          # Code logic utama
├── FormKalkulator.Designer.vb # Design UI form
├── data_tanaman.csv           # Database tanaman
├── harga_pupuk.csv            # Database harga
├── DOKUMENTASI.md             # Dokumentasi lengkap
├── DOKUMENTASI.docx           # Dokumentasi Word
└── README.md                  # File ini
```

---

## 💾 Database CSV

### Format `data_tanaman.csv`
```csv
JenisTanaman,UreaPerhektar,NPKPerhektar,TSPPerhektar,KCLPerhektar,PestisidaPerhektar,UmurPanen
Padi,200,150,100,50,2,120
Jagung,250,200,150,75,3,100
Cabai,150,180,120,60,4,90
```

**Kolom:**
- `JenisTanaman`: Nama tanaman
- `UreaPerhektar`: Kg Urea per hektar
- `NPKPerhektar`: Kg NPK per hektar
- `TSPPerhektar`: Kg TSP per hektar
- `KCLPerhektar`: Kg KCL per hektar
- `PestisidaPerhektar`: Liter pestisida per hektar
- `UmurPanen`: Hari sampai panen

### Format `harga_pupuk.csv`
```csv
NamaBahan,HargaPerKg,Satuan,Kategori
Urea,2500,Kg,Pupuk
NPK,3500,Kg,Pupuk
Insektisida,75000,Liter,Pestisida
```

**Kolom:**
- `NamaBahan`: Nama pupuk/pestisida
- `HargaPerKg`: Harga per satuan (Rupiah)
- `Satuan`: Kg atau Liter
- `Kategori`: Pupuk atau Pestisida

---

## 🎨 Desain Interface

### Tema Warna
- **Primary (Hijau)**: `#4CAF50` - Tema pertanian
- **Background**: `#F5F5F5` - Abu-abu terang
- **Accent (Kuning)**: `#FFF9C4` - Panel total

### Font
- **Heading**: Segoe UI, Bold, 18pt
- **Body**: Segoe UI, Regular, 10pt
- **Code**: Consolas, 9pt

---

## 🔧 Pengembangan Lanjutan

### Fitur Roadmap
- [ ] Database online (MySQL/SQL Server)
- [ ] Multi-user & user authentication
- [ ] Grafik analisis biaya
- [ ] Export ke Excel & PDF
- [ ] Mobile version (Android)
- [ ] Jadwal pemupukan otomatis
- [ ] Integrasi harga real-time (API)
- [ ] Cloud backup

## 📞 Kontak & Support

Jika ada pertanyaan atau butuh bantuan:
- 📧 Email: Erysigit95@gmail.com
- 💬 Issues:(https://github.com/eryjp95-png/KALKULATOR-KEBUTUHAN-PUPUK-PESTISIDA.git)

---


