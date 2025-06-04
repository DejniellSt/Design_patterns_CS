namespace Builder_design_pattern;


public class User
{
    public string FirstName;
    public string SecondName;
    public int Age;
    public string Email;
    public string Phone;

    public override string ToString()
    {
        return $"Imie {FirstName}, Nazwisko {SecondName}, Wiek {Age}, Email {Email}, Tel {Phone}";
    }
}

public class UserBuilder
{
    private User user = new User();

    public UserBuilder setFirstName(string firstname)
    {
        user.FirstName = firstname;
        return this;
    }

    public UserBuilder setSecondName(string secondname)
    {
        user.SecondName = secondname;
        return this;
    }

    public UserBuilder setAge(int age)
    {
        user.Age = age;
        return this;
    }

    public UserBuilder setEmail(string email)
    {
        user.Email = email;
        return this;
    }

    public UserBuilder setPhone(string phone)
    {
        user.Phone = phone;
        return this;
    }

    public User Build()
    {
        return user;
    }

}

class Program
{
    static void Main(string[] args)
    {
        var user = new UserBuilder()
            .setFirstName("Dejniel")
            .setSecondName("St")
            .setAge(32)
            .setEmail("test@wp.pl")
            .setPhone("123")
            .Build();

        Console.WriteLine("Utworzono użytkownika");
        Console.WriteLine(user);
    }
}

