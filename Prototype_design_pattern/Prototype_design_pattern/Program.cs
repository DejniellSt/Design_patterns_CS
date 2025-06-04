namespace Prototype_design_pattern;


public interface IPrototype
{
    IPrototype Clone();
}

public class Person : IPrototype
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    // Konstruktor 
    public Person(string name, int age, int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    // Metoda klonujaca
    public IPrototype Clone()
    {
        return new Person(Name, Age,Salary);
    }

    public void Show()
    {
        Console.WriteLine($"Osoba {Name}, Wiek {Age}, Kasa {Salary}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Utworzenie oryginalnego obiektu
        Person oryginal = new Person("Dejniel", 32,1000000);
        oryginal.Show();

        // Utworzenie clonu
        Person clone = (Person)oryginal.Clone();
        clone.Name = "Magda";
        clone.Age = 30;
        clone.Salary = 1000000;

        Console.WriteLine("Po klonowaniu i zmianie danych ");
        oryginal.Show();
        clone.Show();
    }
}

