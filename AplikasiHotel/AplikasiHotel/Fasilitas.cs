using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class RoomFacilities
    {
        public string RoomType { get; set; }
        public List<string> Facilities { get; set; }

        // Invariant
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(RoomType != null);
            Contract.Invariant(Facilities != null);
            Contract.Invariant(Facilities.Count > 0);
        }


    }

    public class RoomFacilitiesLibrary
    {
        public List<RoomFacilities> GetRoomFacilities()
        {
            // No pre or post condition for this method

            var roomFacilitiesList = new List<RoomFacilities>();

            // Create some sample room facilities data
            var singleRoomFacilities = new RoomFacilities()
            {
                RoomType = "Single Room",
                Facilities = new List<string>() { "Air conditioning", "TV", "Mini fridge", "Ensuite bathroom", "Free Wi-Fi" }
            };
            var doubleRoomFacilities = new RoomFacilities()
            {
                RoomType = "Double Room",
                Facilities = new List<string>() { "Air conditioning", "TV", "Mini fridge", "Ensuite bathroom", "Free Wi-Fi", "Balcony" }
            };
            var suiteFacilities = new RoomFacilities()
            {
                RoomType = "Suite",
                Facilities = new List<string>() { "Air conditioning", "TV", "Mini fridge", "Ensuite bathroom", "Free Wi-Fi", "Balcony", "Living room", "Kitchenette" }
            };

            // Add the sample data to the list of room facilities
            roomFacilitiesList.Add(singleRoomFacilities);
            roomFacilitiesList.Add(doubleRoomFacilities);
            roomFacilitiesList.Add(suiteFacilities);

            return roomFacilitiesList;
        }
    }
}
