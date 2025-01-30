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
        public event PropertyChangedEventHandler PropertyChanged;

        public void Dummy()
        {
            PropertyChanged(this, 
                
                new PropertyChangedEventArgs("Dummy"));


        }

        //public string AktuelleBewoelkung;
        public string AktuelleBewoelkung { get; set; }

        public List<string> WetterListe { get; set; }
        // public double AktuelleTemperatur { get; set; }
        private double _AktuelleTemperatur;


        //fahren=celsius * 1.8 + 32

        public double AktuelleTemperaturFahrenheit { get; set; }


        public double AktuelleTemperatur
        {
            get { return _AktuelleTemperatur; }
            set {
                //value = celsius
                _AktuelleTemperatur = value; 
                AktuelleTemperaturFahrenheit = _AktuelleTemperatur * 1.8 + 32;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, 
                        new PropertyChangedEventArgs("AktuelleTemperatur")
                        );
                    PropertyChanged(this,
                       new PropertyChangedEventArgs("AktuelleTemperaturFahrenheit")
                       );
                }
                //Inform GUI
            
            }
        }

        //prop Wetter
        //prop Person

    }
}
