using System.Collections.Generic;

namespace MethodOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int år;
            while (true)
            {
                Console.WriteLine("Vänligen skriv in det år du föddes: ");
                if (int.TryParse(Console.ReadLine(), out år))
                    break;
                Console.WriteLine("Ogiltigt år, försök igen.");

            }

            Console.WriteLine("Vänligen skriv in den månad du föddes: ");
            string månad = Console.ReadLine();

            int dag; 
            while (true)
            {
                Console.WriteLine("Vänligen skriv in den dag du föddes: ");
                if (int.TryParse(Console.ReadLine(), out dag))
                    break;
                Console.WriteLine("Ogiltig dag, försök igen.");
            }

            Console.WriteLine("Vill du att datumet ska vara med stora bokstäver? (j/n)");
            bool uppercase = Console.ReadLine().ToLower() == "j";
            Console.WriteLine(Datum(år, månad, dag, uppercase));
          
        }

        static string Datum(int år, string månad)
        {
            return $"{år} {månad}";
        }

        static string Datum(int år, string månad, int dag)
        {
            return $"{år} {månad} {dag}";
        }

        static string Datum(int år, string månad, int dag, bool uppercase)
        {
            var full = $"{år} {månad} {dag}";
            return uppercase ? full.ToUpper() : full;
        }
    }
}
