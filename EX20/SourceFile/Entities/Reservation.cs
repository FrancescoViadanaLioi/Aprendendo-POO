using System;
using System.Collections.Generic;
using EX20.Entities.Exceptions;

namespace EX20.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; private set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn) throw new DomainException("The check-out date must be after the check-in date.");
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn < DateTime.Now || checkOut < DateTime.Now) throw new DomainException("The new date must be in the future or on today's date.");
            if (checkOut <= checkIn) throw new DomainException("The check-out date must be after the check-in date.");
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room: {RoomNumber}, Check-In: {CheckIn.ToString("dd/MM/yyyy")}, Check-Out: {CheckOut.ToString("dd/MM/yyyy")}, Duration: {Duration()} nights";
        }
    }
}
