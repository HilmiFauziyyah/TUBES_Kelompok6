using AplikasiHotel;

namespace LoginTest
{
    [TestClass]
    public class UnitTestLogin
    {
        [TestMethod]
        public void TestMethodLogin()
        {
            Login login = new Login();

            string username = login.config.Username;
            Assert.AreEqual("admin", username);

            string password = login.config.Password;
            Assert.AreEqual("pasword123", password);
        }
    }
}