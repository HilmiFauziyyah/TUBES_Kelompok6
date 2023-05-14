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

            public void CekKetersediaanKamar()
            {
                // Kontrak pra-kondisi
                if (jumlahKamar <= 0 || nomorKamar.Length != jumlahKamar || statusKamar.Length != jumlahKamar)
                {
                    throw new ArgumentException("Parameter tidak valid.");
                }

                int kamarTersedia = 0;

                Console.WriteLine("\nKetersediaan Kamar:");
                Console.WriteLine("===================");

                string[] status = new string[] { "tersedia", "terisi" };
                for (int i = 0; i < jumlahKamar; i++)
                {
                    // Kontrak pasca-kondisi
                    if (Array.IndexOf(status, statusKamar[i]) < 0)
                    {
                        throw new InvalidOperationException("Operasi tidak berhasil dilakukan.");
                    }

                    int index = Array.IndexOf(status, statusKamar[i]);
                    Console.WriteLine("Kamar " + nomorKamar[i] + " " + status[index]);
                    if (statusKamar[i] == "tersedia")
                    {
                        kamarTersedia++;
                    }
                }

                if (kamarTersedia == 0)
                {
                    Console.WriteLine("Maaf, semua kamar sudah terisi");
                }
            }

            public void PesanKamar()
            {
                // Kontrak pra-kondisi
                if (jumlahKamar < 1 || nomorKamar.Length != jumlahKamar || statusKamar.Length != jumlahKamar || namaPengunjung.Length != jumlahKamar)
                {
                    throw new ArgumentException("Parameter tidak valid.");
                }


                Console.WriteLine("Silahkan Pilih Tipe Kamar");
                Console.WriteLine("1. Single Room (101 -105)");
                Console.WriteLine("2. Double Room (106 -109)");
                Console.WriteLine("3. Suite (110)");
                Console.WriteLine();

                tipeKamar selection = new tipeKamar();


                while (!selection.IsSelectionComplete())
                {
                    Console.WriteLine("Pilih Tipe Kamar (1-3):");
                    string user_input = Console.ReadLine();
                    selection.ProcessInput(user_input);
                }
                string tipe = selection.GetSelectedRoomType();

                Console.WriteLine("Masukkan Nomor kamar yang ingin dipesan: ");
                int nomor;
                string input = Console.ReadLine();
                //MARSYA DBC
                //precondition
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("!!input tidak boleh kosong!!");
                    return;
                }
                else
                {
                    try
                    {
                        nomor = int.Parse(input);
                    }
                    //postcondition
                    catch (FormatException)
                    {
                        Console.WriteLine("!!input bukan angka!!");
                        return;
                    }
                }

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

                        Console.WriteLine("\nKamar " + nomor + " bertipe " + tipe + " berhasil dipesan atas nama " + nama + ", dengan harga " + hargaKamar[i] + " per malam");
                        return;
                    }
                }

                Console.WriteLine("\nMaaf, kamar dengan nomor " + nomor + " tidak tersedia atau tidak sesuai ");

                // Kontrak pasca-kondisi
                for (int i = 0; i < jumlahKamar; i++)
                {
                    if (nomorKamar[i] == nomor && statusKamar[i] == "tersedia")
                    {
                        throw new InvalidOperationException("Operasi tidak berhasil dilakukan.");
                    }
                }
            }

            // Table-driven construction

            public void CekStatusKamar()
            {

                string[,] statusKamarTable = new string[jumlahKamar, 2];

                for (int i = 0; i < jumlahKamar; i++)
                {
                    if (statusKamar[i] == "tersedia")
                    {
                        statusKamarTable[i, 0] = "Tersedia";
                        statusKamarTable[i, 1] = "";
                    }
                    else
                    {
                        statusKamarTable[i, 0] = "Terisi";
                        statusKamarTable[i, 1] = " atas nama " + namaPengunjung[i];
                    }
                }

                Console.WriteLine("\nStatus Kamar:");
                Console.WriteLine("==============");

                for (int i = 0; i < jumlahKamar; i++)
                {
                    Console.WriteLine("Kamar " + nomorKamar[i] + " : " + statusKamarTable[i, 0] + statusKamarTable[i, 1]);
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
