using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Perpustakaan
{
    public class Buku
    {
        public string Judul;
        public string Penulis;
        public int TahunTerbit;

        public Buku(string Judul, string Penulis, int TahunTerbit)
        {
            this.Judul = Judul;
            this.Penulis = Penulis;
            this.TahunTerbit = TahunTerbit;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul: {this.Judul}, Penulis: {this.Penulis}, Tahun Terbit: {this.TahunTerbit}");
        }
    }
}
