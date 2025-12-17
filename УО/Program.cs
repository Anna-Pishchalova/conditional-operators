using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УО
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 10;
            switch (t)
            {
                case 1 when (t < 0):
                    {
                        Console.WriteLine("Зима");
                    }
                break;
                case 2 when (t >= 0 && t <= 15):
                    {
                        Console.WriteLine("Весна/осень");
                    }
                break;
                case 3 when (t >= 15):
                    {
                        Console.WriteLine("Лето");
                    }
                break;
            }
        }
    }
}
