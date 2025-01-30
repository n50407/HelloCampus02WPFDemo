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



        //fahren=celsius * 1.8 + 32

        //public double AktuelleTemperaturFahrenheit { get; set; }
        private double _aktuelleTemperaturFahrenheit;

        public double AktuelleTemperaturFahrenheit
        {
            get { return _aktuelleTemperaturFahrenheit; }
            //get { return _AktuelleTemperatur * 1.8 + 32;  }

            set { _aktuelleTemperaturFahrenheit = value; }
        }

        private void SetMeinValue(string value)
        {
            var dummy = value;
        }

        private double _AktuelleTemperatur;
        public double AktuelleTemperatur
        {
            get { return _AktuelleTemperatur; }
            set {
                //value = celsius
                _AktuelleTemperatur = value;
                _aktuelleTemperaturFahrenheit = _AktuelleTemperatur * 1.8 + 32;
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
