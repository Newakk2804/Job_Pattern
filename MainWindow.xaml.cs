using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Job_Pattern
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository rep;
        NewAnimal NewA;
        ChangeAnimal ChangeA;
        public MainWindow()
        {
            InitializeComponent();
            AddNewAnimal.Click += (s, e) =>
            {
                if (rep == null)
                {
                    rep = new Repository();
                }
                NewA = new NewAnimal(rep);
                NewA.Show();
                LB.ItemsSource = rep.animals;
            };

            Update.Click += (s, e) =>
            {
                LB.Items.Refresh();
            };

            SaveData.Click += (s, e) =>
            {
                rep.SaveData();
            };

            Delete.Click += (s, e) =>
            {
                rep.Delete((IAnimal)LB.SelectedItem);
                LB.Items.Refresh();
            };

            LB.SelectionChanged += (s, e) =>
            {
                IAnimal animal = LB.SelectedItem as IAnimal;
                TBoxName.Text = animal.Name;   
            };

            Change.Click += (s, e) =>
            {
                IAnimal animal = LB.SelectedItem as IAnimal;
                animal.Name = TBoxName.Text;
            };
        }
    }
}
