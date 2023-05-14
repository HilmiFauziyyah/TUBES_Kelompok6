using HotelApplication;

namespace UnitTesting_1302210081
{
    [TestClass]
    public class UnitTestfasilitas
    {
        [TestMethod]
        public void TestMethodfasilitas()
        {
            RoomFacilitiesLibrary roomFacilitiesLibrary = new RoomFacilitiesLibrary();
            var result = roomFacilitiesLibrary.GetRoomFacilities();

            // Assert
            Assert.IsInstanceOfType(result, typeof(List<RoomFacilities>));
            Assert.IsTrue(result.Count > 0);
        }
    }
}