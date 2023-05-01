using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Pattern
{
    class Mammals : IAnimal
    {
        static int counter;

        static Mammals() { counter = 1; }

        public Mammals(string Name)
        {
            if (Name == "Имя")
            {
                this.Name = Name + $" {counter}";
            }
            else
            {
                this.Name = Name;
            }
            counter++;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            if (GetType().Name == "Mammals")
            {
                return $"{"Имя: " + this.Name} {"Вид: Млекопитающие"}";
            }
            else
            {
                return null;
            }
        }
    }
}
