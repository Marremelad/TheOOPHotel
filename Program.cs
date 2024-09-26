//Gruppuppgift - The OOP hotel
//Mauricio Corte
//.NET24

using System.Text.RegularExpressions;

namespace TheOOPHotel;

class Program
{
    static void Main(string[] args)
    {
        // Get name.
        string? GetName()
        {
            Console.Write("Hello, and welcome to the OOP hotel.\nPlease enter your name: ");
            string? name;
            
            while (true)
            {
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name can not be empty.");
                    continue;
                }
                break;
            }

            return name;

        }
        
        // Get email.
        string GetEmail()
        {
            Console.WriteLine("Please enter your email.");
           
            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Regular expression pattern for email validation
            string? email;

            while (true)
            {
                email = Console.ReadLine();

                if (string.IsNullOrEmpty(email))
                {
                    Console.WriteLine("Email can not be empty.");
                    continue;
                }

                if (regex.IsMatch(email))
                {
                    break; // Exit loop if email format is correct
                }
                else Console.WriteLine("Invalid email format. Please try again.");

            }

            return email;
        }
        
        // Get phone number.
        string? GetPhoneNumber()
        {
            Console.Write("Please enter your phone number:");
            string? phoneNumber = Console.ReadLine();
            return phoneNumber;
        }
        
        // Get start date.
        DateTime GetStartDate()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Please enter the desired start of your booking date using this format: {currentDate:yyyy-MM-dd}");
            
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

            return parsedDate;
        }
        
        // Get length of stay in days.
        int GetLengthOfStayInDays()
        {
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

            return lengthOfStayInDays;
        }
        
        // Create instance of HotelBooking object.

        string? name = GetName();
        // HotelBooking booking = new HotelBooking(GetName(), GetStartDate(), GetLengthOfStayInDays());
        // booking.DisplayTotalPrice();
        // booking.ChangeEndDate(new DateTime(2024, 09, 27 ));
        // booking.DisplayTotalPrice();

    }
    
}