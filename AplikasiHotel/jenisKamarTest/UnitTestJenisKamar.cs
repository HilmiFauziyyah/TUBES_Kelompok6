using AplikasiHotel;
namespace jenisKamarTest
{
    [TestClass]
    public class testJenisKamar
    {
        [TestMethod]
        public void TesJenisKamar()
        {
                // Arrange
                tipeKamar tipeKamar = new tipeKamar();

                // Act
                tipeKamar.ProcessInput("1");

                // Assert
                Assert.AreEqual("Single Room", tipeKamar.GetSelectedRoomType());
        }
        public void ProcessInput_InvalidInput_RoomTypeIsNull()
        {
            // Arrange
            tipeKamar tipeKamar = new tipeKamar();

            // Act
            tipeKamar.ProcessInput("5");

            // Assert
            Assert.IsNull(tipeKamar.GetSelectedRoomType());
        }

        public void IsSelectionComplete_SelectionNotComplete_ReturnsFalse()
        {
            // Arrange
            tipeKamar tipeKamar = new tipeKamar();

            // Act
            bool isComplete = tipeKamar.IsSelectionComplete();

            // Assert
            Assert.IsFalse(isComplete);
        }

        public void IsSelectionComplete_SelectionComplete_ReturnsTrue()
        {
            // Arrange
            tipeKamar tipeKamar = new tipeKamar();

            // Act
            tipeKamar.ProcessInput("2");
            bool isComplete = tipeKamar.IsSelectionComplete();

            // Assert
            Assert.IsTrue(isComplete);
        }
    }
}
 