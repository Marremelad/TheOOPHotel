using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TheOOPHotel;

public class Person
{
    // Class fields.
    private string? _name;
    private string? _email;
    private string? _phoneNumber;
    
    // Constructor.
    public Person(string? name, string? email, string? phoneNumber)
    {
        _name = name;
        _email = email;
        _phoneNumber = phoneNumber;
    }
    
    // Getter and setter for _name.
    public string? Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name can not be empty.");
            }

            _name = value;

        }
    }
    
    // Getter and setter for _email.
    public string? Email
    {
        
        get => _email;
        set
        {
            
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Email can not be empty");
            }
            
            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Check for valid email format with regular expression.
            if (!regex.IsMatch(value))
            {
                throw new ArgumentException("Invalid email format");
            }

            _email = value;
        }
    }
}