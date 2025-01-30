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
        public int Bevölkerung { get; set; }
        public bool EU { get; set; }

        //automatich Property - Details bleiben verborgen
        // public int Glueckszahl{ get; set; }


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
            }
            else
            {
                AusgabeGluecksstatus = "guter Glücksstatus";
                GluecksstatusFarbe = "green";

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
