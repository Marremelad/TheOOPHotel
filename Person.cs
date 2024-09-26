using System.ComponentModel.DataAnnotations;

namespace TheOOPHotel;

public class Person
{
    private string? _name;
    private string? _email;
    private string? _phoneNumber;


    public Person(string? name, string email, string phoneNumber)
    {
        _name = name;
        _email = email;
        _phoneNumber = phoneNumber;
    }
}