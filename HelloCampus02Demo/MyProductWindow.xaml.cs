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
    /// Interaction logic for MyProductWindow.xaml
    /// </summary>
    public partial class MyProductWindow : Window
    {
        public MyProductWindow()
        {
            InitializeComponent();
        }

        private void AddCheckBox(object sender, RoutedEventArgs e)
        {
            //deklarativ
            //<StackPanel x:Name="MyLastStackPanel">
            //<CheckBox IsChecked="true" Background="Yellow">Dummy</CheckBox>
            //Prozedural
            CheckBox myNewCheckbox = new CheckBox();
            myNewCheckbox.Content = "Dummy";
            myNewCheckbox.IsChecked = true;
            myNewCheckbox.Background = new SolidColorBrush(Color.FromArgb(255, 255, 100, 0));
            MyLastStackPanel.Children.Add(myNewCheckbox);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
