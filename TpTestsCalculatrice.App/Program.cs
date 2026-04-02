namespace TpTestsCalculatrice.App;

class Program
{
    static void Main(string[] args)
    {
        Calculatrice calc = new Calculatrice();

        Console.WriteLine(calc.Addition(2, 3));
        Console.WriteLine(calc.Division(10, 2)); 

        // Le test manuel n'est pas suffisant car il faut effectuer un test avant 
        
    }
}
