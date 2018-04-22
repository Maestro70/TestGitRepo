using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("6aro", 10);
            Console.WriteLine(dog.Name + " - " + dog.Age);
        }
    }
}
