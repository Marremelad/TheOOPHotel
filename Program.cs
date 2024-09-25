
namespace TheOOPHotel;

class Program
{
    static void Main(string[] args)
    {
        // Get name.
        Console.Write("Hello, and welcome to the OOP hotel.\nPlease enter your name: ");
        string? name = Console.ReadLine();
        
        // Get start date for booking.
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"Please enter the desired start of your booking date using this format: {currentDate:yyyy-MM-dd}");
        
        // Get start date.
        DateTime parsedDate;
        while (true)
        {
            string? dateString = Console.ReadLine(); // Ensure specific format.
            bool isValid = DateTime.TryParseExact(dateString, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out parsedDate);

            
            if (isValid)
            {
                if (parsedDate.Date >= DateTime.Now.Date)
                {
                    break;
                }
                Console.WriteLine("Start date can not be in the past.");
            }
            else Console.WriteLine("Not a valid date format");
        }
        
        // Get length of stay in days.
        Console.WriteLine("How many days would you like to stay at the OOP hotel?");
        int lengthOfStayInDays;
        
        while (true)
        {
            string? userInput = Console.ReadLine();
            if (int.TryParse(userInput, out lengthOfStayInDays))
            {
                if (lengthOfStayInDays > 0)
                {
                    break;
                }
                Console.WriteLine("Length of stay can not be less than one day.");
            }
            else Console.WriteLine("Please enter a valid number");
        }

        // Create instance of HotelBooking object.
        HotelBooking booking = new HotelBooking(name, parsedDate, lengthOfStayInDays);
        booking.DisplayTotalPrice();
        booking.ChangeEndDate(new DateTime(2024, 09, 27 ));
        booking.DisplayTotalPrice();

    }
}