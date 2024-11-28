using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Cat : Animal
    {
        string animalBreed;
        public override string AnimalBreed
        {
            get
            {
                return animalBreed;
            }
            set
            {
                animalBreed = value;
            }
        }
        public Cat(string animalBreed)
            : base(animalBreed)
        { 
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }

    }
}
