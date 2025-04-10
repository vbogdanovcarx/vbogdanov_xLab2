using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLab_Unit_2_2
{
    internal class Program
    {
        class Country
        {
            public string state;
            public int number;

            public void Print()
            {
                Console.WriteLine($"{state}, {number}");
            }
        }
        static void Main(string[] args)
        {
            Country name = new Country();
            name.state = "Tennessee";
            name.number = 16;

            name.Print();
        }
    }
}