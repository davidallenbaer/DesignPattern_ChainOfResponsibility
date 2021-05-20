using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            Console.WriteLine("\nRequested Amount 5600");
            atm.withdraw(5600);
            Console.WriteLine("\nRequested Amount 2900");
            atm.withdraw(2900);
            Console.WriteLine("\nRequested Amount 700");
            atm.withdraw(700);
            Console.Read();
        }
    }
}
