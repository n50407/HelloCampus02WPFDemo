using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02Demo.MeineToDos
{
    internal class ToDoViewModel
    {
        public ObservableCollection<ToDo> TodoList { get; set; }

        private ToDoContext _context = new ToDoContext();

        public void AddToDo(ToDo toDo)
        {
            //_context.ToDos --> Tabelle in der DB
            _context.ToDos.Add(toDo);
            //_context erzeugt ein INSERT INTO ToDo....
            _context.SaveChanges();
            //Änderungen werden gespeichert
            TodoList.Add(toDo);//Auch in der ObsList ablegen
        }
    }
}
