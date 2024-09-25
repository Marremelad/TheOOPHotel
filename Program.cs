
namespace TheOOPHotel;

class HotelBooking
{
    // Class fields.
    private DateTime _startDate;
    private DateTime _endDate;
    private string? _name;
    private int _pricePerNight = 100;

    // Constructor.
    public HotelBooking(string? guestName, DateTime startDate, int lengthOfStayInDays)
    {
        this._name = guestName;
        this._startDate = startDate;
        this._endDate = _startDate.AddDays(lengthOfStayInDays);
    }

    // Getter and setter for _name.
    public string? Name
    {
        get => _name;
        set => _name = value;
    }

    // setter for _startDate.
    public DateTime StartDate
    {
        get => _startDate;
        set
        {
            if (value < DateTime.Now)
            {
                throw new ArgumentException("Start date can not be in the past.");
            }

            _startDate = value;
        }
    }

    // Getter and setter for _endDate.
    public DateTime EndDate
    {
        get => _endDate;
        set
        {
            if (value < _startDate)
            {
                throw new ArgumentException("End date can not be before start date.");
            }

            _endDate = value;
        }
    }

    //Display booking info.
    public void DisplayBookingInfo()
    {
        Console.WriteLine(_endDate.ToString("yyyy-MM-dd"));
    }

    // Change start date.
    public void ChangeStartDate(DateTime startDate)
    {
        StartDate = startDate;
    }

    // Change end date.
    public void ChangeEndDate(DateTime endDate)
    {
        EndDate = endDate;
    }

    // Calculate price.
    public int CalculatePrice()
    {
        int lengthOfStayInDays = (_endDate - _startDate).Days;
        return _pricePerNight * lengthOfStayInDays;
    }

    // Display total price.
    public void DisplayTotalPrice()
    {
        Console.WriteLine($"Your stay at the OOP hotel will cost you {CalculatePrice()} Bytes.");

    }
}

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