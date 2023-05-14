using AplikasiHotel;
using HotelApplication;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Silahkan Login");
        Console.WriteLine("Sebelum masuk ke sistem perhotelan");
        Console.WriteLine("");

        Login login = new Login();
        Console.WriteLine("Username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Password: ");
        string password = Console.ReadLine();

        if (login.IsInputValid(username, password))
        {

            makanan<string> pemesananMakanan = new makanan<string>();
            var roomFacilitiesLibrary = new RoomFacilitiesLibrary();
            var roomFacilitiesList = roomFacilitiesLibrary.GetRoomFacilities();

            Hotel hotel = new Hotel();


            // Menambahkan beberapa makanan ke daftar makanan
            pemesananMakanan.TambahMakanan("Nasi Goreng");
            pemesananMakanan.TambahMakanan("Mie Goreng");
            pemesananMakanan.TambahMakanan("Sate Ayam");

            Console.WriteLine("\nSelamat Datang Di Sistem Perhotelan");
            Console.WriteLine("===================================");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Cek Ketersediaan Kamar");
                Console.WriteLine("2. Pesan Kamar");
                Console.WriteLine("3. Cek Status Kamar");
                Console.WriteLine("4. Checkout");
                Console.WriteLine("5. Cek Harga");
                Console.WriteLine("6. Pesan Makanan");
                Console.WriteLine("7. Cek Fasilitas Kamar");
                Console.WriteLine("8. Keluar dari Aplikasi");


                Console.Write("\nPilihan Anda (1-6): ");
                int pilihan = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        hotel.CekKetersediaanKamar();
                        break;
                    case 2:
                        hotel.PesanKamar();
                        break;
                    case 3:
                        hotel.CekStatusKamar();
                        break;
                    case 5:
                        hotel.HitungHarga();
                        break;
                    case 6:
                        pemesananMakanan.PesanMakanan();
                        break;
                    case 7:
                        // Tampilkan fasilitas kamar berdasarkan tipe kamarnya
                        Console.WriteLine("Tipe kamar yang tersedia:");
                        foreach (var roomFacilities in roomFacilitiesList)
                        {
                            Console.WriteLine(roomFacilities.RoomType);
                        }
                        Console.WriteLine("\nPilih tipe kamar:");
                        var roomType = Console.ReadLine();
                        var selectedRoomFacilities = roomFacilitiesList.FirstOrDefault(x => x.RoomType.ToLower() == roomType.ToLower());
                        if (selectedRoomFacilities != null)
                        {
                            Console.WriteLine("\nFasilitas kamar :  " + selectedRoomFacilities.RoomType);
                            foreach (var facility in selectedRoomFacilities.Facilities)
                            {
                                Console.WriteLine("\n- " + facility);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Inputan Tidak Boleh Kosong.");
                        }
                        break;
                    case 8:
                        Console.WriteLine("\nTerima kasih telah menggunakan Aplikasi Perhotelan");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nMaaf, pilihan yang Anda masukkan tidak valid");
                        break;
                }
            }
        }

        else
        {
            Console.WriteLine(login.config.Login_gagal);
        }
    }
}



