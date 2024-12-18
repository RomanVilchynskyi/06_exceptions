using _06_exceptions;
using System.Security.Principal;

internal class Program
{
    static int DivideNumber(int a, int b)
    {
        int res = 0;
        try
        {
            res = a / b;
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Inner exception --> " + ex.Message);
            throw;
        }
        return res;
    }
    private static void Main(string[] args)
    {
        /*Matrix m = new Matrix(2, 2);
        Console.WriteLine(m);
        Console.WriteLine("\n" + new string ('=', 40) + "\n");
        m[0,0] = 10;
        m[0,1] = 20;
        m[1,0] = 30;
        m[1,1] = 40;
        Console.WriteLine(m);*/

        /*int a, b, res;
        while (true)
        {
            try
            {
                Console.WriteLine("Enter two numbers :: ");
                a = int.Parse(Console.ReadLine()!);
                b = int.Parse(Console.ReadLine()!);
                res = DivideNumber(a,b);
                Console.WriteLine($"{a} / {b} = {res}");
                break;
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\t Message :: {ex.Message}");
                Console.WriteLine($"\t HelpLink :: {ex.HelpLink}");
                Console.WriteLine($"\t Source :: {ex.Source}");
                Console.WriteLine($"\t TargetSite :: {ex.TargetSite}");

                foreach(var key in ex.Data.Keys)
                {
                    Console.WriteLine($"{key} --> {ex.Data[key]}");
                }
                Console.ResetColor();
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\t Message      :: {ex.Message}");
                Console.ResetColor();

            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finally");   
                Console.ResetColor();
            }
        }*/

        /*Product p = new Product();
        try
        {
            p.Name = "Milk"; //"hole bread"
            p.DateIn = DateTime.Parse("20/12/2024");
        }
        catch(BadDateProductException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t Message :: {ex.Message}");
            Console.WriteLine($"\t Error date :: {ex.errorDate}");
            Console.WriteLine($"\t Source :: {ex.Source}");
            Console.WriteLine($"\t TargetSite :: {ex.TargetSite}");
        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t Message :: {ex.Message}");
            Console.WriteLine($"\t HelpLink :: {ex.HelpLink}");
            Console.WriteLine($"\t Source :: {ex.Source}");
            Console.WriteLine($"\t TargetSite :: {ex.TargetSite}");

            foreach (var key in ex.Data.Keys)
            {
                Console.WriteLine($"{key} --> {ex.Data[key]}");
            }
            Console.ResetColor();
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Name product : {p.Name,-15} Date : {p.DateIn}");
        Console.ResetColor();*/

        try
        {
            Acount account = new Acount();

            Console.Write("Enter email: ");
            string inputEmail = Console.ReadLine()!;
            account.Email = inputEmail;
            Console.WriteLine("Valid Email: " + account.Email);

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}