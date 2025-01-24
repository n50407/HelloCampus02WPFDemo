using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02Demo.Models
{
    internal class Wiederholung
    {
        public string Hallo { get; set; }
        public string NiceColor { get; set; }
        public List<String> Wochentage { get; set; }

        public Wiederholung()
        {
            Wochentage = new List<string>()
                {
                    "Montag",
                    "Dienstag",
                    "Mittwoch",
                    "Donnerstag"
                };
        }
    }
}
