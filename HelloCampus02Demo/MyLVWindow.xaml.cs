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
    /// Interaction logic for MyLVWindow.xaml
    /// </summary>
    public partial class MyLVWindow : Window
    {
        public MyLVWindow()
        {
            InitializeComponent();

            //Datencontext setzen
            LV myLV = new LV();
            myLV.Bezeichnung = "ISY";
            myLV.Stunden = 32;
            myLV.Abgeschlossen = false;
            myLV.Level = "Green";

            this.DataContext = myLV; //VM


            //Staatenbezeichnung -- AT / DE / CH /USA
            //Sprache -- DE / EN / FR
            //Bevölkerungsgröße ---> Slider / TextBox
            //ToogleButton -- "gedrückt wenn bei der EU
            //Aufgaben
            //1. Klasse --> Staat
            //2. Windows mit Databinding --> StaatenWindow
            //3. DataContext im Constructor setzen
        }
    }
}
