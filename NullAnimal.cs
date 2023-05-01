using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Pattern
{
    public class NullAnimal : IAnimal
    {

        public NullAnimal() { this.Name = "Not Determined"; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{"Имя: " + this.Name}";
        }
    }
}
