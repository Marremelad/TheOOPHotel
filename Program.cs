//Gruppuppgift - The OOP hotel
//Mauricio Corte
//.NET24

namespace TheOOPHotel;

class Program
{
    static void Main()
    {
        //Create instance of Person object.
        Person person = new Person(UserInput.GetName(), UserInput.GetEmail(), UserInput.GetPhoneNumber());
        
        // Create instance of HotelBooking object.
        HotelBooking booking = new HotelBooking(person, UserInput.GetStartDate(), UserInput.GetLengthOfStayInDays());

        // Display the booking information.
        booking.DisplayBookingInfo();
    }
    
}