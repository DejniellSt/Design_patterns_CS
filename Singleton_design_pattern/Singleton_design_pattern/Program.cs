namespace Singleton_design_pattern;

//wzorzec singleton
public class Singleton
{
    private static Singleton instance;
    private static readonly object lockObj = new object();

    // prywatny konstruktor uniemozliwia tworzenie instancji z zewnatrz
    private Singleton()
    {
        Console.WriteLine("Konstruktor Singletona został wywołany");
    }

    // publiczna własność dostępu
    public static Singleton Instance
    {
        get
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

    // przykładowa metoda
    public void DoSomething()
    {
        Console.WriteLine("Metoda Singletona");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Instancja obiektu po raz pierwszy");
        Singleton s1 = Singleton.Instance;
        s1.DoSomething();

        Console.WriteLine("Kolejna instancja Singletona");
        Singleton s2 = Singleton.Instance;
        s2.DoSomething();

        Console.WriteLine($"Sprawdzamy czy to aby na pewno ten sam obiekt? {ReferenceEquals(s1, s2)}");
    }
}

