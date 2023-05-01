using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.IO;

namespace Job_Pattern
{
    public class Repository : ISavingData
    {
        public List<IAnimal> animals;

        public Repository()
        {
            animals = new List<IAnimal>();
        }

        public void Add(IAnimal Animal)
        {
            this.animals.Add(Animal);
        }

        public void Delete(IAnimal Animal)
        {
            this.animals.Remove(Animal);
        }

        public void SaveData()
        {
            using (StreamWriter sw = new StreamWriter($@"Data.txt"))
            {
                foreach (var item in animals)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }
    }
}
