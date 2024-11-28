using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Dog:Animal
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
                animalBreed = "Cобака";
                animalBreed = value;
            }
        }
        public Dog(string animalBreed)
            : base(animalBreed)
        {
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }

    }
}
