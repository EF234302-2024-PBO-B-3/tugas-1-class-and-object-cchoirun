using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        public string Merk;
        public string Prosesor;
        public int Ram;
        public int Penyimpanan;
        public Laptop(string Merk, string Prosesor, int Ram, int Penyimpanan) 
        {
            this.Merk = Merk;
            this.Prosesor = Prosesor;
            this.Ram = Ram;
            this.Penyimpanan = Penyimpanan;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {this.Merk}, Prosesor: {this.Prosesor}, RAM: {this.Ram} GB, Penyimpanan: {this.Penyimpanan} GB");
        }
    }
}
