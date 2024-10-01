
namespace TheOOPHotel;

public class HotelBooking
{
    // Class fields.
    public Person Guest { get; set; }
    private DateTime _startDate;
    private DateTime _endDate;
    private readonly int _pricePerNight = 100;

    // Constructor.
    public HotelBooking(Person guest, DateTime startDate, int lengthOfStayInDays)
    {
        Guest = guest;
        StartDate = startDate;
        EndDate = _startDate.AddDays(lengthOfStayInDays);
    }
    
    // Getter and setter for _guest.
    

    // Getter and setter for _startDate.
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
        Console.WriteLine($"\nContact information-\nGuest name: {Guest.Name}\nEmail: {Guest.Email}\nPhone number: {Guest.PhoneNumber}");
        Console.WriteLine($"\nYour stay at The OOP Hotel begins {StartDate:yyyy-MM-dd} and ends {EndDate:yyyy-MM-dd}");
        DisplayTotalPrice();
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
    private int CalculatePrice()
    {
        int lengthOfStayInDays = (EndDate - StartDate).Days;
        return _pricePerNight * lengthOfStayInDays;
    }

    // Display total price.
    private void DisplayTotalPrice()
    {
        Console.WriteLine($"Your stay at the OOP hotel will cost you {CalculatePrice()} Bytes.");
    }
}