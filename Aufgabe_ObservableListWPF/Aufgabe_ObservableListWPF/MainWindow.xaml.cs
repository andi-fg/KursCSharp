using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Aufgabe_ObservableListWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> personen;
        public MainWindow()
        {
            InitializeComponent();
            personen = new ObservableCollection<Person>()
         {
             new Person(){Name="Prabhat",Land="India"},

             new Person(){Name="Smith",Land="US"}
         };
            personList.ItemsSource = personen;
        }

        private void speichernBtn_Click(object sender, RoutedEventArgs e)
        {
            personen.Add(new Person() { Name = nameTxt.Text, Land = landTxt.Text });
            landTxt.Text = "";
            nameTxt.Text = "";
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Land { get; set; }
    }
}
