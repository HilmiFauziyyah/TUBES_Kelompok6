
using AplikasiHotel;

internal class Program
{
    public static void Main(string[] args)
    {

        Hotel hotel = new Hotel();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Cek Ketersediaan Kamar");
                Console.WriteLine("2. Pesan Kamar");
                Console.WriteLine("3. Cek Status Kamar");
                Console.WriteLine("4. Checkout");
                Console.WriteLine("5. Cek Harga");
                Console.WriteLine("6. Pesan Makanan");
                Console.WriteLine("7. Keluar dari Aplikasi");


                Console.Write("\nPilihan Anda (1-6): ");
                int pilihan = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 2:
                        hotel.PesanKamar();
                        break;

                }
            }
        
    }
}


