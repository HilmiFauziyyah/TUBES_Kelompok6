using AplikasiHotel;
namespace checkStatusKamarTest
{
    [TestClass]
    public class testCekStatusKamar
    {
        [TestMethod]
        public void tesCekStatusKamar()
        {
            // Arrange
            Hotel hotel = new Hotel();
            string expectedOutput = "\nStatus Kamar:\r\n" +
            "==============\r\n" +
            "Kamar 101 : Tersedia\r\n" +
            "Kamar 102 : Tersedia\r\n" +
            "Kamar 103 : Tersedia\r\n" +
            "Kamar 104 : Tersedia\r\n" +
            "Kamar 105 : Tersedia\r\n" +
            "Kamar 106 : Tersedia\r\n" +
            "Kamar 107 : Tersedia\r\n" +
            "Kamar 108 : Tersedia\r\n" +
            "Kamar 109 : Tersedia\r\n" +
            "Kamar 110 : Tersedia\r\n";

            // Act
            string actualOutput = CaptureConsoleOutput(() =>
            {
                hotel.CekStatusKamar();
            });

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        private string CaptureConsoleOutput(Action action)
        {
            var standardOut = Console.Out;
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);

            action.Invoke();

            Console.SetOut(standardOut);
            return consoleOutput.ToString();
        }
    }
}