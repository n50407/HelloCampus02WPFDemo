using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02Demo
{
    internal class Staat: INotifyPropertyChanged
    {
        
        private int MyZahl; //kein Property
        public string MyText;


        public string Name { get; set; }
        public string Sprache { get; set; }
        // public int Bevölkerung { get; set; }
        private int _Bevoelkerung;

        public int Bevoelkerung
        {
            get { return _Bevoelkerung; }
            set { _Bevoelkerung = value;

                LogikKleinGross();
                
            if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Bevoelkerung"));
                }
            }
        }

        private void LogikKleinGross()
        {
          if (Bevoelkerung< 1000000)
            {
                AusgabeKleinGross = "Kleinstaat";
                KleinGross = "Kleinstaat.png";
            }
            else
            {
                AusgabeKleinGross = "Großstaat";
                KleinGross = "Gross.jpg";
            }

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("AusgabeKleinGross"));
                PropertyChanged(this, new PropertyChangedEventArgs("KleinGross"));
            }
        }

        public bool EU { get; set; }

        //automatich Property - Details bleiben verborgen
        // public int Glueckszahl{ get; set; }

        private string _KleinGross;

        public string KleinGross
        {
            get { return _KleinGross; }
            set { _KleinGross = value; }
        }

        public string AusgabeKleinGross { get; set; }



        private int _Glueckszahl;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Glueckszahl
        {
            get { return _Glueckszahl; }
            set {
                _Glueckszahl = value; 
                CalcStatus();
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Glueckszahl"));
                }            
            }
        }

        public void CalcStatus()
        {
            if (Glueckszahl < 50)
            {
                AusgabeGluecksstatus = "schlechter Glücksstatus";
                GluecksstatusFarbe = "red";
                KleinGross = "Kleinstaat.png";
            }
            else
            {
                AusgabeGluecksstatus = "guter Glücksstatus";
                GluecksstatusFarbe = "green";
                KleinGross = "Gross.jpg";

            }

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("AusgabeGluecksstatus"));
                PropertyChanged(this, new PropertyChangedEventArgs("GluecksstatusFarbe"));
                
            }
        }

        //gut oder schlecht
        public string AusgabeGluecksstatus { get; set; }
        //grün oder rot
        public string GluecksstatusFarbe { get; set; }






    }
}
