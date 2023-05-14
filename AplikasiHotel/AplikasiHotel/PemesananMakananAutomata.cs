using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiHotel
{
    public class PemesananMakananAutomata
    {
        public List<string> daftarMakanan = new List<string>();

        public enum PesanMakananState
        {
            PesanLagi,
            MakananDipilih,
            Terkonfirmasi
        }

        public PesanMakananState state = PesanMakananState.PesanLagi;
        public PesanMakananState State
        {
            get { return state; }
        }

        public int makanan = -1;
        public int Makanan
        {
            get { return makanan; }
        }

        public void TambahMakanan(string makanan)
        {
            daftarMakanan.Add(makanan);
        }

        public void ProcessInput(string input)
        {
            switch (state)
            {
                case PesanMakananState.PesanLagi:
                    if (input.ToLower() == "ya")
                    {
                        state = PesanMakananState.MakananDipilih;
                    }
                    else if (input.ToLower() == "tidak")
                    {
                        state = PesanMakananState.Terkonfirmasi;
                    }
                    break;
                case PesanMakananState.MakananDipilih:
                    if (int.TryParse(input, out int pilihan) && pilihan >= 1 && pilihan <= 3)
                    {
                        makanan = pilihan;
                        state = PesanMakananState.Terkonfirmasi;
                    }
                    break;
                default:
                    break;
            }
        }

        public string GetMessage()
        {
            switch (state)
            {
                case PesanMakananState.PesanLagi:
                    return "Apakah anda ingin memesan makanan lagi? (ya/tidak)";
                case PesanMakananState.MakananDipilih:

                    Console.WriteLine("\nDaftar Makanan Tersedia:");
                    for (int i = 0; i < daftarMakanan.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {daftarMakanan[i]}");
                    }
                    return "\nPilih nomor makanan yang ingin dipesan (1-3): ";
                case PesanMakananState.Terkonfirmasi:

                    return "Pesanan Anda telah diterima.";
                default:
                    return "Input tidak valid.";
            }
        }

        public string GetNamaMakanan()
        {
            if (makanan < 1 || makanan > daftarMakanan.Count)
            {
                Console.WriteLine("Maaf, nomor makanan yang Anda pilih tidak valid.");
            }
            else
            {
                Console.WriteLine($"Anda telah memesan {daftarMakanan[makanan - 1]}.");
            }

            return string.Empty;
        }

    }
}

