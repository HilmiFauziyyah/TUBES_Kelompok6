using AplikasiHotel;
namespace Test_PemesananMakananAutomata
{
    [TestClass]
    public class TestingKelas
    {
        [TestMethod]
        public void Testing1()
        {
            // Arrange
            var automata = new PemesananMakananAutomata();
            automata.TambahMakanan("Nasi Goreng");
            automata.TambahMakanan("Mie Goreng");
            automata.TambahMakanan("Sate Ayam");

            // Act
            automata.ProcessInput("ya");
            automata.ProcessInput("2");

            // Assert
            Assert.AreEqual(PemesananMakananAutomata.PesanMakananState.Terkonfirmasi, automata.State);
            Assert.AreEqual(2, automata.Makanan);
        }

        [TestMethod]
        public void ProcessInput_Should_NotUpdateStateAndMakanan_When_InputIsInvalid()
        {
            // Arrange
            var automata = new PemesananMakananAutomata();
            automata.TambahMakanan("Nasi Goreng");
            automata.TambahMakanan("Mie Goreng");
            automata.TambahMakanan("Sate Ayam");

            // Act
            automata.ProcessInput("ya");
            automata.ProcessInput("5");

            // Assert
            Assert.AreEqual(PemesananMakananAutomata.PesanMakananState.MakananDipilih, automata.State);
            Assert.AreEqual(-1, automata.Makanan);
        }
    }
}