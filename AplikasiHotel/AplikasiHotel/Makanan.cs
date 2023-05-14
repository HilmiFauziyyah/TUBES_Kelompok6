using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplikasiHotel;


namespace AplikasiHotel
{
    public class makanan<T>
    {
        public List<T> daftarMakanan;

        public makanan()
        {
            daftarMakanan = new List<T>();
        }

        public void TambahMakanan(T makanan)
        {
            daftarMakanan.Add(makanan);
        }

        public void PesanMakanan()
        {
            if (daftarMakanan.Count == 0)
            {
                Console.WriteLine("Maaf, makanan tidak tersedia saat ini.");
            }
            else
            {
                Console.WriteLine("\nDaftar Makanan Tersedia:");
                for (int i = 0; i < daftarMakanan.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {daftarMakanan[i]}");
                }

                Console.Write("\nSilakan pilih nomor makanan yang ingin dipesan: ");
                int nomorMakanan = int.Parse(Console.ReadLine());

                if (nomorMakanan < 1 || nomorMakanan > daftarMakanan.Count)
                {
                    Console.WriteLine("Maaf, nomor makanan yang Anda pilih tidak valid.");
                }
                else
                {
                    Console.WriteLine($"Anda telah memesan {daftarMakanan[nomorMakanan - 1]}.");
                }
            }
        }
    }
}