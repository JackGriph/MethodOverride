using System.Collections.Generic;

namespace MethodOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange år, månad, dag och om det ska vara versaler true/false");
            Console.Write("År: ");
            int år = Convert.ToInt32(Console.ReadLine());
            Console.Write("Månad: ");
            string månad = Console.ReadLine();
            Console.Write("Dag: ");
            int dag = Convert.ToInt32(Console.ReadLine());
            Console.Write("Versaler (true/false): ");
            bool uppercase = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("Här har du olika format på datumet:");
            Console.WriteLine(Datum(år, månad));
            Console.WriteLine(Datum(år, månad, dag));   
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
