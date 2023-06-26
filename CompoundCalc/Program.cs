using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            startProc:
            Console.WriteLine("Enter Initial Fund");
            var InitFund = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Monthly Interest Percentage");
            var Interest = float.Parse((float.Parse(Console.ReadLine())/100F).ToString());
            Console.WriteLine("Enter Period By Month");
            var Period = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("==================================================");
            Console.WriteLine($"Fund after {Period} month would be : {Calc.CompoundCalc(InitFund,Interest,Period)}");
            Console.WriteLine("");
            Console.WriteLine("do you want to continue? Y/N");
            var decide = Console.ReadLine();
            if(decide.ToLower() == "y")
                goto startProc;
            Console.ReadKey();
        }
    }
}
