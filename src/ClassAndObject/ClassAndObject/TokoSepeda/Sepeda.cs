using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.TokoSepeda
{
    public class Sepeda
    {
        public string Merk;
        public string Tipe;
        public double Berat;
        public Sepeda(string Merk, string Tipe, double Berat) 
        {
            this.Merk = Merk;
            this.Tipe = Tipe;
            this.Berat = Berat;
        }

        public void TampilkanInformasi()
        {
            Console.WriteLine($"Merek: {this.Merk}, Tipe: {this.Tipe}, Berat: {this.Berat.ToString(CultureInfo.InvariantCulture)} kg");
        }
    }
}
