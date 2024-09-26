using System.ComponentModel.DataAnnotations;

namespace TheOOPHotel;

public class Person
{
    public string? _name;
    public string? _email;
    public string? _phoneNumber;


    public Person(string? name, string? email, string? phoneNumber)
    {
        _name = name;
        _email = email;
        _phoneNumber = phoneNumber;
    }
}