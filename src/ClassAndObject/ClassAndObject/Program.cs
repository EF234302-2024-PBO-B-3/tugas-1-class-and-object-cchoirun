using ClassAndObject.Kendaraan;
using ClassAndObject.OperasiMatematika;
using ClassAndObject.Perpustakaan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku = new Buku("Laskar Pelangi", "Andrea Hirata", 2005);
            buku.TampilkanInfo();


            // Kendaraan
            Mobil mobil = new Mobil("Tesla", "Cyber Truck", 2023);
            mobil.TampilkanSpesifikasi();

            // Laptop
            Laptop laptop = new Laptop("Acer", "Intel i7", 16, 512);
            laptop.TampilkanSpesifikasi();

            // Sepeda
            Sepeda sepeda = new Sepeda("Polygon", "Pixy", 14.2);
            sepeda.TampilkanInformasi();

            // Kalkulator
            Kalkulator calculator = new Kalkulator();
            string input = "";

            while (input != "exit")
            {
                Console.WriteLine("Masukkan angka pertama:");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Masukkan angka kedua:");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Pilih operasi (Tambah, Kurang, Kali, Bagi):");
                string operasi = Console.ReadLine();

                switch (operasi.ToLower())
                {
                    case "tambah":
                        calculator.Tambah(a, b);
                        break;
                    case "kurang":
                        calculator.Kurang(a, b);
                        break;
                    case "kali":
                        calculator.Kali(a, b);
                        break;
                    case "bagi":
                        calculator.Bagi(a, b);
                        break;
                    default:
                        Console.WriteLine("Operasi tidak valid. Silakan pilih Tambah, Kurang, Kali, atau Bagi.");
                        break;
                }

                Console.WriteLine("Ketik 'exit' untuk keluar, atau tekan Enter untuk melanjutkan.");
                input = Console.ReadLine();
            }


        }
    }
}
