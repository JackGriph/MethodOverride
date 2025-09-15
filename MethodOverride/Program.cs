using System.Collections.Generic;

namespace MethodOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Datum(2002, "Mars"));
            Console.WriteLine(Datum(2002, "Mars", 18)); 
            Console.WriteLine(Datum(2002, "Mars", 18, true));
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
