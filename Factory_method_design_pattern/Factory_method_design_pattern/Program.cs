namespace Factory_method_design_pattern;

// Produkt 
public interface IDocument
{
    void Print();
}

// Konkretny produkt
public class PDFDocument: IDocument
{
    public void Print()
    {
        Console.WriteLine("Printing PDF Doc...");
    }
}

public class WordDocument: IDocument
{
    public void Print()
    {
        Console.WriteLine("Printing Word Doc...");
    }
}

// Twórca
public abstract class DocumentCreator
{
    public abstract IDocument CreateDocument();
}

// Konkretny twórca
public class PDFCreator : DocumentCreator
{
    public override IDocument CreateDocument()
    {
        return new PDFDocument();
    }
}

public class WordCreator : DocumentCreator
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

class Program
{
    static void Main(string[] args)
    {
        DocumentCreator creator;

        creator = new PDFCreator();
        IDocument pdf = creator.CreateDocument();
        pdf.Print(); // Output: Printing PDF Doc...

        creator = new WordCreator();
        IDocument word = creator.CreateDocument();
        word.Print(); // Output: Printing Word Doc...
    }
}

