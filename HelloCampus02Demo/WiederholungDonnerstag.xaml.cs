using HelloCampus02Demo.Models;
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

namespace HelloCampus02Demo
{
    /// <summary>
    /// Interaction logic for WiederholungDonnerstag.xaml
    /// </summary>
    public partial class WiederholungDonnerstag : Window
    {
        public WiederholungDonnerstag()
        {
            InitializeComponent();

            ViewModelTageswetter myVM = new ViewModelTageswetter();
            myVM.AktuelleTemperatur = 25.5;
            myVM.WetterListe = new List<string>()
            {
                "sonnig",
                "wolkig",
                "regnerisch",
                "stürmisch"
            };

            this.DataContext = myVM;

           // MyWetterPanel.DataContext = myVM;
            //MyPersonenPanel.DataContext= myVM;

        }

        private void CalcRandomTemperatur(object sender, RoutedEventArgs e)
        {
            //zufällige Zahl zwischen -40 und +40
            Random rnd = new Random();
            var zz = rnd.Next(-40, 41);

            ViewModelTageswetter vm=(ViewModelTageswetter)this.DataContext;

            vm.AktuelleTemperatur = zz;
            
        }
    }
}
