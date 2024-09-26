
namespace TheOOPHotel;

public class HotelBooking
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