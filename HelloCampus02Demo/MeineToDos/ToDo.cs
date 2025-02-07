using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02Demo.MeineToDos
{

    //POCO - PLAIN OLD CLR OBJECT
    internal class ToDo //INotifyPropertyChanged
    {
        public int ID { get; set; }
        public string Bezeichnung { get; set; }
        public int Prioritaet { get; set; }
    }
}
