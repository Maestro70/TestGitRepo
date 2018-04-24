using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogProject
{
    class StartDog
    {
        static void Main(string[] args)
        {
            var listOfDogs = new List<Dog>();
            var dog1 = new Dog();
            var dog2 = new Dog();
            dog1.Name = "6aro";
            dog1.Age = 10;
            dog2.Name = "Mi60";
            dog2.Age = 7;

            listOfDogs.Add(dog1);
            listOfDogs.Add(dog2);

            foreach(var dog in listOfDogs)
            {
                Console.WriteLine(dog.Name + " - " + dog.Age);
            }
        }
    }
}
