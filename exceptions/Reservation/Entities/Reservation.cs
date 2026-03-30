using System;
using System.Globalization;

namespace Module.Entities
{
    sealed class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room: " + RoomNumber
                + "CheckIn: " + CheckIn.ToString("dd/MM/YYYY")
                + "cHECKOut" + CheckOut.ToString("dd/MM/YYYY");
        }
    }
}