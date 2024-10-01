using System.Text.RegularExpressions;

namespace TheOOPHotel;

public static class UserInput
{
        // Get name.
        public static string GetName()
        {
            Console.Write("Hello and welcome to the OOP hotel.\nPlease enter your name: ");
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
        public static string GetEmail()
        {
            Console.Write("Please enter your email: ");
           
            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Regular expression pattern for email validation.
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
                else Console.Write("Invalid email format. Please try again: ");

            }

            return email;
        }
        
        // Get phone number.
        public static string GetPhoneNumber()
        {
            Console.Write("Please enter your phone number: ");
            
            Regex regex = new Regex(@"^\+?[1-9]\d{1,14}$|^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$");  // Regular expression for common phone number patterns.
            string? phoneNumber;
            
            while (true)
            {
                 phoneNumber = Console.ReadLine();

                 if (string.IsNullOrEmpty(phoneNumber))
                 {
                     Console.WriteLine("Phone number can not be empty.");
                     continue;
                 }

                 if (regex.IsMatch(phoneNumber))
                 {
                     break;
                 }
                 else Console.Write("Invalid number format. Please try again: ");
            }
            
            return phoneNumber;
        }
        
        // Get start date.
        public static DateTime GetStartDate()
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
        public static int GetLengthOfStayInDays()
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
}