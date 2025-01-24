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

namespace HelloCampus02Demo.Views
{
    /// <summary>
    /// Interaction logic for XAMLBeispiel.xaml
    /// </summary>
    public partial class XAMLBeispiel : Window
    {
        public XAMLBeispiel()
        {
            InitializeComponent();
            Wiederholung wdh = new Wiederholung()
            {
                Hallo = "Guten Morgen Campus02",
                NiceColor = "Green"
            };

            this.DataContext = wdh;

        }

        private void AddCheckBox_EventHandler(object sender, RoutedEventArgs e)
        {//
            Button ausloeser = (Button)sender; //is as 


            CheckBox cb = new CheckBox();
            cb.Content = "Neues Kontrollkästchen";

            StackPanel stackPanel = (StackPanel)ausloeser.Content;
            stackPanel.Children.Add(cb);


           // myFirstPanel.Children.Add(cb);




        }
    }
}
