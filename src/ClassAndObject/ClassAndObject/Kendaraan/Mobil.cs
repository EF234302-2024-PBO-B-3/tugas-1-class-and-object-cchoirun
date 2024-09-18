using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.Kendaraan
{
    public class Mobil
    {
        public string Merk;
        public string Model;
        public int TahunProduksi;

        public Mobil(string Merk, string Model, int TahunProduksi)
        {
            this.Merk = Merk;
            this.Model = Model;
            this.TahunProduksi = TahunProduksi;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {this.Merk}, Model: {this.Model}, Tahun Produksi: {this.TahunProduksi}");
        }
    }
}
