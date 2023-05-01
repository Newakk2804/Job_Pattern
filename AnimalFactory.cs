using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Pattern
{
    static class AnimalFactory
    {
        public static IAnimal GetAnimal(string typeAnimal, string Name)
        {
            switch (typeAnimal)
            {
                case "Млекопитающие": return new Mammals(Name);
                case "Птицы": return new Birds(Name);
                case "Земноводные": return new Amphibians(Name);
                default: return new NullAnimal();
            }
        }
    }
}
