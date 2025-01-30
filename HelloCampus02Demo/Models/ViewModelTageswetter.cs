using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02Demo.Models
{
    internal class ViewModelTageswetter: INotifyPropertyChanged //STRG + .
    {
        //public string AktuelleBewoelkung;
        public string AktuelleBewoelkung { get; set; }

        public List<string> WetterListe { get; set; }
        // public double AktuelleTemperatur { get; set; }
        private double _AktuelleTemperatur;

        public event PropertyChangedEventHandler PropertyChanged;

        public double AktuelleTemperatur
        {
            get { return _AktuelleTemperatur; }
            set {
                _AktuelleTemperatur = value; 
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, 
                        new PropertyChangedEventArgs("AktuelleTemperatur")
                        );
                }
                //Inform GUI
            
            }
        }

        //prop Wetter
        //prop Person

    }
}
