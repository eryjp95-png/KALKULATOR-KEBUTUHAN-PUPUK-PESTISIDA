# PANDUAN SETUP PROJECT DI VISUAL STUDIO

## 🚀 Langkah-langkah Setup Project

### STEP 1: Buat Project Baru

1. **Buka Visual Studio 2019/2022**

2. **Create New Project**
   - Klik "Create a new project"
   - Atau File → New → Project

3. **Pilih Template**
   - Cari: "Windows Forms App (.NET Framework)"
   - Bahasa: Visual Basic
   - Platform: Windows
   - Klik "Next"

4. **Configure Project**
   ```
   Project name:     KalkulatorPupuk
   Location:         C:\Users\YourName\Documents\
   Solution name:    KalkulatorPupuk
   Framework:        .NET Framework 4.7.2 atau lebih tinggi
   ```
   - Klik "Create"

---

### STEP 2: Setup Form Designer

1. **Rename Form Default**
   - Di Solution Explorer, klik kanan "Form1.vb"
   - Pilih "Rename"
   - Ganti nama menjadi: `FormKalkulator.vb`

2. **Delete Form Default (jika perlu)**
   - Hapus Form1.vb yang lama
   - Atau gunakan sebagai base

---

### STEP 3: Add Code Files

#### A. Tambah File FormKalkulator.vb

1. Klik kanan pada project → Add → Existing Item
2. Browse ke file `FormKalkulator.vb`
3. Atau copy-paste code langsung:
   - Klik kanan Form → View Code
   - Delete semua code existing
   - Paste code dari file FormKalkulator.vb

#### B. Tambah File FormKalkulator.Designer.vb

1. Di Solution Explorer, klik tanda ▶ di sebelah FormKalkulator.vb
2. Klik kanan FormKalkulator.Designer.vb → View Code
3. Replace semua code dengan code dari file Designer

**ATAU Manual:**

1. Klik FormKalkulator.vb di Solution Explorer
2. Tekan F7 untuk buka Designer
3. Copy-paste code Designer

---

### STEP 4: Add Data Files (CSV)

1. **Copy File CSV ke Project**
   - Copy `data_tanaman.csv` dan `harga_pupuk.csv`
   - Paste ke folder project (di lokasi .vb files)

2. **Set Copy to Output Directory**
   - Klik kanan `data_tanaman.csv` di Solution Explorer
   - Properties → Copy to Output Directory → "Copy always"
   - Ulangi untuk `harga_pupuk.csv`

**Atau manual:**

```
📁 KalkulatorPupuk/
  ├── 📁 bin/
  │   └── 📁 Debug/
  │       ├── data_tanaman.csv      ← Copy kesini
  │       └── harga_pupuk.csv       ← Copy kesini
  ├── FormKalkulator.vb
  └── FormKalkulator.Designer.vb
```

---

### STEP 5: Set Startup Form

1. Klik kanan Project → Properties
2. Tab "Application"
3. Set "Startup form" → FormKalkulator
4. Save (Ctrl+S)

---

### STEP 6: Build & Run

1. **Build Solution**
   ```
   Menu: Build → Build Solution
   Shortcut: Ctrl+Shift+B
   ```

2. **Check for Errors**
   - Lihat Error List (View → Error List)
   - Fix jika ada error

3. **Run Application**
   ```
   Menu: Debug → Start Debugging
   Shortcut: F5
   ```

---

## 🔧 TROUBLESHOOTING

### Error: "File tidak ditemukan"

**Solusi:**
```
1. Pastikan data_tanaman.csv dan harga_pupuk.csv ada di:
   - Folder bin/Debug/
   - Atau set "Copy to Output Directory" = "Copy always"

2. Atau ubah path di code:
   Private PathDataTanaman As String = Application.StartupPath & "\data_tanaman.csv"
   Private PathHargaPupuk As String = Application.StartupPath & "\harga_pupuk.csv"
```

### Error: "Type not defined" atau "Import System.IO"

**Solusi:**
```vb
' Tambahkan di bagian atas FormKalkulator.vb:
Imports System.IO
Imports System.Text
```

### Error: Designer tidak load

**Solusi:**
1. Rebuild Project (Build → Rebuild Solution)
2. Close dan reopen Visual Studio
3. Atau create form manually dari designer

### Error: Button tidak ada event handler

**Solusi:**
```vb
' Pastikan di Designer.vb ada:
Friend WithEvents btnHitung As Button

' Dan di FormKalkulator.vb:
Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
```

---

## 📋 CHECKLIST SETUP

### ✅ Pre-Build Checklist

- [ ] FormKalkulator.vb ter-copy dengan benar
- [ ] FormKalkulator.Designer.vb ter-copy dengan benar
- [ ] data_tanaman.csv ada di project
- [ ] harga_pupuk.csv ada di project
- [ ] CSV files set "Copy to Output Directory" = "Copy always"
- [ ] Startup form = FormKalkulator
- [ ] Imports System.IO sudah ada

### ✅ Post-Build Checklist

- [ ] Build sukses tanpa error
- [ ] File .exe terbuat di bin/Debug/
- [ ] CSV files ter-copy ke bin/Debug/
- [ ] Aplikasi bisa run (F5)
- [ ] Form tampil dengan benar
- [ ] Bisa load data dari CSV

---

## 🎯 STRUKTUR PROJECT YANG BENAR

```
KalkulatorPupuk/               ← Solution folder
│
├── KalkulatorPupuk/           ← Project folder
│   │
│   ├── FormKalkulator.vb      ← Main code file
│   ├── FormKalkulator.Designer.vb  ← UI design code
│   ├── FormKalkulator.resx    ← Resources (auto-generated)
│   │
│   ├── data_tanaman.csv       ← Data tanaman
│   ├── harga_pupuk.csv        ← Data harga
│   │
│   ├── My Project/
│   │   ├── Application.Designer.vb
│   │   └── Resources.Designer.vb
│   │
│   ├── bin/
│   │   └── Debug/
│   │       ├── KalkulatorPupuk.exe     ← Executable
│   │       ├── data_tanaman.csv        ← Copy of CSV
│   │       └── harga_pupuk.csv         ← Copy of CSV
│   │
│   └── obj/
│
└── KalkulatorPupuk.sln        ← Solution file
```

---

## 💡 TIPS DEVELOPMENT

### 1. Test Mode untuk Development

Tambahkan di FormKalkulator.vb:

```vb
Private Sub FormKalkulator_Load(...)
    InisialisasiForm()
    
    ' MODE TEST - Hapus setelah development selesai
    #If DEBUG Then
        cboJenisTanaman.SelectedIndex = 0
        txtLuasLahan.Text = "2.5"
        cboKondisiTanah.SelectedIndex = 1
    #End If
    
    MuatDataDariFile()
End Sub
```

### 2. Debug Message

Untuk debugging, gunakan:

```vb
Debug.WriteLine("Data loaded: " & ListTanaman.Count & " items")
Console.WriteLine("Calculating for: " & cboJenisTanaman.Text)
```

### 3. Error Handling

Selalu wrap file operations dengan Try-Catch:

```vb
Try
    ' Code here
Catch ex As Exception
    MessageBox.Show("Error: " & ex.Message)
    Debug.WriteLine(ex.StackTrace)
End Try
```

---

## 🔍 TESTING

### Test Scenario 1: Load Data
1. Run aplikasi (F5)
2. Check apakah ComboBox terisi
3. Check message "Data berhasil dimuat"

### Test Scenario 2: Perhitungan
1. Pilih tanaman: Padi
2. Luas lahan: 2
3. Kondisi: Subur
4. Klik Hitung
5. Check hasil di DataGridView
6. Check total biaya

### Test Scenario 3: Save File
1. Lakukan perhitungan
2. Klik Simpan
3. Pilih lokasi
4. Check file CSV terbuat
5. Buka dengan Excel/Notepad

### Test Scenario 4: Print
1. Lakukan perhitungan
2. Klik Cetak
3. Check preview muncul
4. Check format laporan

---

## 🚀 DEPLOYMENT

### Build Release Version

1. **Change to Release Mode**
   - Toolbar: Debug → Release

2. **Build**
   - Build → Build Solution

3. **Collect Files**
   ```
   📁 Distribusi/
     ├── KalkulatorPupuk.exe
     ├── data_tanaman.csv
     ├── harga_pupuk.csv
     └── README.txt
   ```

4. **Create Installer (Optional)**
   - Install Visual Studio Installer Projects
   - Add → New Project → Setup Project
   - Add Project Output
   - Add Files (CSV)
   - Build

### System Requirements untuk User

```
Minimum:
- OS: Windows 7 SP1 atau lebih tinggi
- .NET Framework 4.7.2
- RAM: 2 GB
- Storage: 50 MB

Recommended:
- OS: Windows 10/11
- .NET Framework 4.8
- RAM: 4 GB
- Storage: 100 MB
```

---

## 📞 SUPPORT

Jika mengalami masalah:

1. Check Error List (View → Error List)
2. Check Output window (View → Output)
3. Rebuild Project (Build → Rebuild Solution)
4. Clean Solution (Build → Clean Solution) lalu Build lagi
5. Restart Visual Studio
6. Check .NET Framework version

---

## ✅ FINAL CHECKLIST

Sebelum submit/deploy:

- [ ] Build sukses tanpa warning
- [ ] Semua fitur berfungsi
- [ ] Data CSV ter-load
- [ ] Perhitungan benar
- [ ] Save file berfungsi
- [ ] Print berfungsi
- [ ] Tidak ada hardcoded path
- [ ] Error handling memadai
- [ ] UI rapi dan konsisten
- [ ] Dokumentasi lengkap

---

**Good Luck! Happy Coding! 🚀**
