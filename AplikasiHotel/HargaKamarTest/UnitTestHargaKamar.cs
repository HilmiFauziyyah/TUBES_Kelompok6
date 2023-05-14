using TotalHarga;
namespace HargaKamarTest
{
    [TestClass]
    public class UnitTestHargaKamar
    {
        [TestMethod]
        public void TestMethodHarga()
        {
            HargaKamar hargaKamar = new HargaKamar();
            int totalHarga = hargaKamar.HitungTotalHarga(101, 2);
            Assert.AreEqual(1500000, totalHarga);

            totalHarga = hargaKamar.HitungTotalHarga(106, 2);
            Assert.AreEqual(2000000, totalHarga);

            totalHarga = hargaKamar.HitungTotalHarga(110, 2);
            Assert.AreEqual(3000000, totalHarga);
        }
    }
}