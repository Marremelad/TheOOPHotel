using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOOPHotel
{
    internal class HotelBooking
    {
        public string GuestName;
        public DateTime StartDate;
        public DateTime EndDate;
        public int PriceTotal;
        private int _price = 1250;
        public HotelBooking(string guestName, DateTime startDate, int lengthOfStay) 
        {   
            this.GuestName = guestName;
            this.StartDate = startDate;
            DateTime endDate = startDate;
            endDate = endDate.AddDays(lengthOfStay);
            this.EndDate = endDate;
            this.PriceTotal = this._price * lengthOfStay;
        }
        public void DisplayBookingInfo()
        {
            Console.WriteLine($"Gästnamn: {this.GuestName}");
            Console.WriteLine($"Startdatum: {this.StartDate:d}");
            Console.WriteLine($"Slutdatum: {this.EndDate:d}");
            Console.WriteLine($"Pris: {this.PriceTotal:d}");
        }
        public void ChangeDuration(int days)
        {
            this.PriceTotal = days * this._price;
            DateTime endDate = this.StartDate;
            endDate = endDate.AddDays(days);
            this.EndDate = endDate;
        }
    }
}
