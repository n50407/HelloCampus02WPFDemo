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
using System.Windows.Shapes;

namespace HelloCampus02Demo.MeineToDos
{
    /// <summary>
    /// Interaction logic for ToDoWindow.xaml
    /// </summary>
    public partial class ToDoWindow : Window
    {
        public ToDoWindow()
        {
            InitializeComponent();

            ToDoViewModel viewModel = new ToDoViewModel();
            viewModel.TodoList = 
                new ObservableCollection<ToDo>();

            viewModel.AddToDo(
                new ToDo()
                {
                    ID=-1,
                    Bezeichnung="Schlafen",
                    Prioritaet=1
                }
                );
            viewModel.AddToDo(
                new ToDo()
                {
                    ID = -1,
                    Bezeichnung = "Essen",
                    Prioritaet = 1
                }
                );
            this.DataContext= viewModel;

        }
    }
}
