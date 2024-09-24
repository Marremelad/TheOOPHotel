namespace TheOOPHotel;

class Program
{
    static void Main(string[] args)
    {
        HotelBooking bokning = Program.MakeBooking();

        // Skriv ut information om bokningen med egenskaper
        Console.WriteLine($"Gästnamn: {bokning.GuestName}");
        Console.WriteLine($"Startdatum: {bokning.StartDate:d}");
        Console.WriteLine($"Slutdatum: {bokning.EndDate:d}");
        Console.WriteLine($"Pris: {bokning.PriceTotal:d}");

        // Skriv ut information om bokningen med en metod istället
        bokning.DisplayBookingInfo();
    }
    static HotelBooking MakeBooking()
    {
        Console.WriteLine("Ange ditt namn");
        string name = Console.ReadLine();
        DateTime startDate = GetValidDate();
        int days;
        string input;
        do
        {
            Console.WriteLine("Hur många dagar vill du boka?");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out days));
        HotelBooking bokning = new HotelBooking(name, startDate, days);
        return bokning;
    }
    static DateTime GetValidDate()
    {
        DateTime today = DateTime.Now;
        DateTime startDate;
        string input;
        while (true)
        {
            Console.WriteLine("Ange datum i formatet åååå-mm-dd");
            input = Console.ReadLine();
            bool validDate = DateTime.TryParseExact(input, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out startDate);
            if (!validDate) { continue; }
            if (startDate < today) {
                Console.WriteLine("Datumet måste vara i framtiden.");
                continue;
            }
            TimeSpan timeDifference = startDate - today;
            TimeSpan year = new TimeSpan(365, 0, 0, 0);
            if (timeDifference > year) {
                Console.WriteLine("Man kan max boka ett år framåt.");
                continue; }
            break;
        }
        return startDate;
    }
}