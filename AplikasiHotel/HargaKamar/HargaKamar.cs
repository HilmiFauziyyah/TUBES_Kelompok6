namespace TotalHarga
{
    public class HargaKamar
    {
        public int HitungTotalHarga(int nomorKamar, int lamaMenginap)
        {
            int hargaKamar = 0;
            if (nomorKamar >= 101 && nomorKamar <= 105)
            {
                hargaKamar = 750000;
            }
            else if (nomorKamar >= 106 && nomorKamar <= 109)
            {
                hargaKamar = 1000000;
            }
            else if (nomorKamar == 110)
            {
                hargaKamar = 1500000;
            }

            int totalHarga = hargaKamar * lamaMenginap;

            return totalHarga;
        }
    }
}