# Folder Crawling Algorithm
## Tentang Program
Program ini adalah sebuah implementasi algoritma BFS dan DFS dalam melakukan Folder Crawling atau pencarian folder berdasarkan query nama folder. Struktur folder pada permasalahan ini direpresentasikan menjadi sebuah graf, kemudian proses traversal divisualisasikan dalam sebuah aplikasi desktop.

Aplikasi Desktop ini dibangun menggunakan kerangka kerja WinForms dengan platform .NET dan di-compile menggunakan Visual Studio.

## Requirement
Program ini bisa dijalankan menggunakan perangkat lunak visual studio. Versi .NET yang kami gunakan adalah .NET Framework v4.7.2, adapun package yang digunakan adalah package MSAGL. Langkah menginstall package adalah sebagai berikut
1. Buka NuGet Package Manager
2. Tuliskan perintah berikut
```
Install-Package AutomaticGraphLayout -Version 1.1.11
Install-Package AutomaticGraphLayout.Drawing -Version 1.1.11
Install-Package AutomaticGraphLayout.WpfGraphControl -Version 1.1.11
Install-Package AutomaticGraphLayout.GraphViewerGDI -Version 1.1.11

```
NuGet akan menginstall semua package di atas dan program siap digunakan.

## How to Use
Program akan bisa dijalankan langsung menggunakan tombol run pada Visual Studio, atau jalankan perintah berikut pada Shell.
```
& '.\bin\Debug\Folder Crawling.exe'
```
Cara lain adalah dengan membuka langsung bin/Debug/Folder Crawling.exe

## Author
Ahmad Romy Zahran (13520009)<br>
Firizky Ardiansyah (13520095) <br>
Muhammad Fahmi Irfan (13520152)