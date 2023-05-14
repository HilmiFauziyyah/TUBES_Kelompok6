using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalHarga;

namespace AplikasiHotel
{
        public class Hotel
        {

            int jumlahKamar = 10;
            int[] nomorKamar = new int[10] { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110 };
            string[] statusKamar = new string[10] { "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia" };
            string[] namaPengunjung = new string[10];
            int[] hargaKamar = new int[10] { 750000, 750000, 750000, 750000, 750000, 1000000, 1000000, 1000000, 1000000, 1500000 };

            public void PesanKamar()
            {
                // Kontrak pra-kondisi
                if (jumlahKamar < 1 || nomorKamar.Length != jumlahKamar || statusKamar.Length != jumlahKamar || namaPengunjung.Length != jumlahKamar)
                {
                    throw new ArgumentException("Parameter tidak valid.");
                }


                Console.WriteLine("Masukkan nomor kamar yang ingin dipesan: ");
                int nomor = int.Parse(Console.ReadLine()); ;
                

                // Looping untuk mencari nomor kamar yang sesuai
                for (int i = 0; i < jumlahKamar; i++)
                {
                    // Kamar ditemukan
                    if (nomorKamar[i] == nomor && statusKamar[i] == "tersedia")
                    {
                        Console.Write("Masukkan nama pengunjung :");
                        string nama = Console.ReadLine();
                        namaPengunjung[i] = nama;
                        statusKamar[i] = "terisi";

                        // Kontrak pasca-kondisi
                        if (namaPengunjung[i] != nama || statusKamar[i] != "terisi")
                        {
                            throw new InvalidOperationException("Operasi tidak berhasil dilakukan.");
                        }

                        Console.WriteLine("\nKamar " + nomor + " berhasil dipesan atas nama " + nama + ", dengan harga " + hargaKamar[i] + " per malam");
                        return;
                    }
                }

                Console.WriteLine("\nMaaf, kamar dengan nomor " + nomor + " tidak tersedia atau sudah terisi");

                // Kontrak pasca-kondisi
                for (int i = 0; i < jumlahKamar; i++)
                {
                    if (nomorKamar[i] == nomor && statusKamar[i] == "tersedia")
                    {
                        throw new InvalidOperationException("Operasi tidak berhasil dilakukan.");
                    }
                }
            }

        public void HitungHarga()
        {
            Console.Write("\nMasukkan nomor kamar: ");

            int nomor = int.Parse(Console.ReadLine());

            int index = Array.IndexOf(nomorKamar, nomor);
            if (index == -1)
            {
                Console.WriteLine("\nMaaf, kamar dengan nomor " + nomor + " tidak ditemukan");
                return;
            }

            if (statusKamar[index] == "tersedia")
            {
                Console.WriteLine("\nMaaf, kamar dengan nomor " + nomor + " belum terisi");
                return;
            }

            Console.Write("Masukkan lama menginap (dalam hari): ");
            int lamaMenginap = int.Parse(Console.ReadLine());


            HargaKamar hargaKamar = new HargaKamar();
            int totalHarga = hargaKamar.HitungTotalHarga(nomor, lamaMenginap);

            Console.WriteLine("\nTotal harga untuk kamar " + nomor + " selama " + lamaMenginap + " hari adalah Rp" + totalHarga);
        }
    }

}
