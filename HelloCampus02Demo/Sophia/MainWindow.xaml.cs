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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloCampus02Demo.Sophia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
  
        public MainWindow()
        {
            InitializeComponent();
            var horoscopeViewModel =new HoroscopeViewModel();
            horoscopeViewModel.Horoscopes.Add
                (
                new Horoscope() { Description="Abc", Name="TEst"}
                );
            //DataContext = new HoroscopeViewModel();
            DataContext = horoscopeViewModel;


        }
    }

}
