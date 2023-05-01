using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Pattern
{
    class Amphibians : IAnimal
    {
        static int counter;

        static Amphibians() { counter = 1; }

        public Amphibians(string Name)
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
            if (GetType().Name == "Amphibians")
            {
                return $"{"Имя: " + this.Name} {"Вид: Земноводные"}";
            }
            else
            {
                return null;
            }
        }
    }
}
