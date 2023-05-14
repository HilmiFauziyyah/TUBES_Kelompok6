using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiHotel
{
    public class tipeKamar
    {
        private string current_state;
        private string room_type;

        public tipeKamar()
        {
            current_state = "start";
            room_type = "";
        }

        public void ProcessInput(string user_input)
        {
            if (current_state == "start")
            {
                if (user_input == "1")
                {
                    room_type = "Single Room";
                    current_state = "single_room_selected";
                }
                else if (user_input == "2")
                {
                    room_type = "Double Room";
                    current_state = "double_room_selected";
                }
                else if (user_input == "3")
                {
                    room_type = "Suite";
                    current_state = "suite_selected";
                }
                //dbc Marsya
                else
                {
                    Console.WriteLine("input salah, mohon input dengan benar");
                }
            }
            else
            {
                Console.WriteLine("input salah, mohon input dengan benar");
            }
        }

        public bool IsSelectionComplete()
        {
            return current_state == "single_room_selected" || current_state == "double_room_selected" || current_state == "suite_selected";
        }

        public string GetSelectedRoomType()
        {
            if (IsSelectionComplete())
            {
                return room_type;
            }
            else
            {
                return null;
            }
        }
    }
}


