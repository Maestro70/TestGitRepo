using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatProject
{
    public class Cat
    {

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }
}
