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
    /// Interaction logic for MyStaatenWindow.xaml
    /// </summary>
    public partial class MyStaatenWindow : Window
    {
        public MyStaatenWindow()
        {
            InitializeComponent();
            Staat myNewStaat=new Staat();
            myNewStaat.Name = "Österreich";
            myNewStaat.Sprache = "Deutsch";
            myNewStaat.Bevölkerung = 9000000;
            myNewStaat.EU = true;

            this.DataContext = myNewStaat;
        }
    }
}
