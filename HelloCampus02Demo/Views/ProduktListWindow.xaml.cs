using HelloCampus02Demo.Models;
using HelloCampus02Demo.ViewModels;
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

namespace HelloCampus02Demo.Views
{
    /// <summary>
    /// Interaction logic for ProduktListWindow.xaml
    /// </summary>
    public partial class ProduktListWindow : Window
    {
        public ProduktListWindow()
        {
            InitializeComponent();

            ProductListViewModel vm = new ProductListViewModel();
            vm.AusgewaehltesProdukt = new Produkt()
            {
                Bezeichnung = "noch nichts ausgewählt"
            };
            vm.ProduktList=new System.Collections.ObjectModel.ObservableCollection<Models.Produkt>();

            vm.AddProdukt(new Models.Produkt 
            { 
                ProduktID = 1, Bezeichnung = "Produkt 1", 
                Kategorie = "Yellow", AufLager = true, Preis = 10.0 
            });
            vm.AddProdukt(new Models.Produkt 
            { 
                ProduktID = 2, Bezeichnung = "Produkt 2", 
                Kategorie = "Blue", AufLager = false, Preis = 20.0 
            });

            this.DataContext = vm;

        }

        private void NeuesProduktHinzufuegen(object sender, RoutedEventArgs e)
        {
            Produkt pNeu = new Produkt()
            {
                ProduktID = 17,
                Bezeichnung = "Neues Produkt",
                Kategorie = "Green"
            };

            var vm= this.DataContext as ProductListViewModel;
            if (vm != null)
            {
                vm.AddProdukt(pNeu);
            }
            
        }
    }
}
