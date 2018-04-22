using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoolProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Mario", 6);
            Console.WriteLine("Hello GitHub!!!");
            Console.WriteLine(cat.Name + "   " + cat.Age);
        }
    }
}
