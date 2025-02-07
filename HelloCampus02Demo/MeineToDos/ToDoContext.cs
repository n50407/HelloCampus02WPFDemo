using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02Demo.MeineToDos
{
    //Zugang zur DB
    //Context erstellt INSERT; UPDATE; DELETE; SELECT --> CRUD
    //Code First --> Zuerst C#-Klasse, DB wird automatisch erzeugt
    internal class ToDoContext: DbContext
    {
        //Tabelle
        public DbSet<ToDo> ToDos { get; set; }

    }
}
