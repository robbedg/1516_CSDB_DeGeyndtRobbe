using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection conn = new Connection();
            Console.WriteLine(conn.ToString());
            Dictionary<int,int> test = conn.Command("CALL bepaal_lijst_van_bij_te_bestellen_artikelen()");
            Console.Write(test.ToList().Count);
            Console.Read();
        }
    }
}
