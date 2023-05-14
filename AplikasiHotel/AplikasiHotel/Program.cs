
using Aplikasi_Hotel;
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
            Hotel hotel = new Hotel();
            makanan<string> pemesananMakanan = new makanan<string>();
            var roomFacilitiesLibrary = new RoomFacilitiesLibrary();
            var roomFacilitiesList = roomFacilitiesLibrary.GetRoomFacilities();
            PemesananMakananAutomata pesanmakanan = new PemesananMakananAutomata();
            makanan<string> PemesananMakanan = new makanan<string>();



            // Menambahkan beberapa makanan ke daftar makanan
            pemesananMakanan.TambahMakanan("Nasi Goreng");
            pemesananMakanan.TambahMakanan("Mie Goreng");
            pemesananMakanan.TambahMakanan("Sate Ayam");
            
            //untuk daftar makanan automata 
            pesanmakanan.TambahMakanan("Nasi Goreng");
            pesanmakanan.TambahMakanan("Mie Goreng");
            pesanmakanan.TambahMakanan("Sate Ayam");

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
                Console.WriteLine("8. Rating Kamar");
                Console.WriteLine("9. Keluar dari Aplikasi");


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
                        Console.WriteLine("Apakah anda sudah memesan makanan sebelumnya? (sudah/belum)");
                        string inputPertanyaan = Console.ReadLine();

                        if (inputPertanyaan.ToLower() == "sudah")
                        {
                            while (true)
                            {
                                Console.WriteLine(pesanmakanan.GetMessage());
                                string input = Console.ReadLine();

                                if (input.ToLower() == "tidak")
                                {

                                    break;
                                }

                                pesanmakanan.ProcessInput(input);

                                if (pesanmakanan.State == PemesananMakananAutomata.PesanMakananState.Terkonfirmasi)
                                {
                                    Console.WriteLine("Pesanan Anda telah diterima.");
                                    string namaMakanan = pesanmakanan.GetNamaMakanan();
                                    Console.WriteLine();

                                    pesanmakanan = new PemesananMakananAutomata();
                                }
                            }
                        }
                        else if (inputPertanyaan.ToLower() == "belum")
                        {
                            pemesananMakanan.PesanMakanan();
                        }
                        else
                        {
                            Console.WriteLine("Input tidak valid.");
                        }
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
                        HotelReviewSystem<int> hotelReviews = new HotelReviewSystem<int>();

                        while (true)
                        {
                            Console.WriteLine(" -- Sistem Rating dan Ulasan Kamar Hotel -- ");
                            Console.WriteLine("1. Tambah Ulasan Kamar");
                            Console.WriteLine("2. Tampilkan Ulasan Kamar");
                            Console.WriteLine("3. Kembali");
                            Console.Write("Pilihan Anda: ");
                            string choice = Console.ReadLine();

                            if (choice == "1")
                            {
                                // nomor kamar
                                int roomNumber;
                                do
                                {
                                    Console.Write("Masukkan Nomor Kamar (101-110): ");
                                    string roomNumberInput = Console.ReadLine();

                                    if (!int.TryParse(roomNumberInput, out roomNumber) || roomNumber < 101 || roomNumber > 110)
                                    {
                                        Console.WriteLine("Nomor Kamar tidak valid. Mohon masukkan angka antara 101 hingga 110.");
                                    }
                                } while (roomNumber < 101 || roomNumber > 110);

                                //rating kamar
                                int rating;
                                do
                                {
                                    Console.Write("Masukkan Rating (1-5): ");
                                    string ratingInput = Console.ReadLine();

                                    if (!int.TryParse(ratingInput, out rating) || rating < 1 || rating > 5)
                                    {
                                        Console.WriteLine("Rating tidak valid. Mohon masukkan angka antara 1 hingga 5.");
                                    }
                                } while (rating < 1 || rating > 5);

                                // komentar kamar
                                Console.Write("Masukkan Komentar: ");
                                string comment = Console.ReadLine();

                                ReviewKamar<int> review = new ReviewKamar<int>()
                                {
                                    RoomNumber = roomNumber,
                                    Rating = rating,
                                    Comment = comment
                                };

                                hotelReviews.AddReview(review);
                                Console.WriteLine();
                                Console.WriteLine("Ulasan berhasil ditambahkan.");
                                Console.WriteLine();
                            }
                            else if (choice == "2")
                            {
                                List<ReviewKamar<int>> allReviews = hotelReviews.GetReviews();
                                if (allReviews.Count == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Belum ada ulasan kamar.");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("-- Ulasan Kamar --");
                                    foreach (var review in allReviews)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Kamar {0}:", review.RoomNumber);
                                        Console.WriteLine("Rating: {0}/5", review.Rating);
                                        Console.WriteLine("Komentar: {0}", review.Comment);
                                        Console.WriteLine();
                                    }
                                }
                            }
                            else if (choice == "3")
                            {
                                Console.WriteLine("Terima kasih. Sampai jumpa!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 9:
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


