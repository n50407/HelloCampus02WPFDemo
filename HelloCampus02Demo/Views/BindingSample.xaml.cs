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
    /// Interaction logic for BindingSample.xaml
    /// </summary>
    public partial class BindingSample : Window
    {
        FridayViewModel fridayViewModel = new FridayViewModel();
        public BindingSample()
        {
            InitializeComponent();
            
            this.DataContext= fridayViewModel;
        }
    }
}
