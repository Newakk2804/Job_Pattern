using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Pattern
{
    class Birds : IAnimal
    {
        static int counter;

        static Birds() { counter = 1; }

        public Birds(string Name)
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
            if (GetType().Name == "Birds")
            {
                return $"{"Имя: " + this.Name} {"Вид: Птицы"}";
            }
            else
            {
                return null;
            }
        }
    }
}
