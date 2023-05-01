using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Job_Pattern
{
    /// <summary>
    /// Логика взаимодействия для NewAnimal.xaml
    /// </summary>
    public partial class NewAnimal : Window
    {
        public NewAnimal()
        {
            InitializeComponent();
        }

        public NewAnimal(Repository rep)
        {
            InitializeComponent();
            BtnAdd.Click += (s, e) =>
            {
                rep.Add(AnimalFactory.GetAnimal($"{ComboBox.Text}", $"{TBoxName.Text}"));
                this.Close();
            };

            BtnCancel.Click += (s, e) =>  this.Close();
        }
    }
}
