using ConsoleApp18;

internal class Program
{
    private static void Main(string[] args)
    {
        Euro euro = new Euro(300);
        Manat manat = euro;
        Console.WriteLine(manat.Valyuta);
        Console.WriteLine("----");
        Dollar dollar = new Dollar(300);
        Manat manat2 = dollar;
        Console.WriteLine(manat2.Valyuta);
    }
}