using HelloCampus02Demo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02Demo.ViewModels
{
    internal class ProductListViewModel: INotifyPropertyChanged
    {
        //List<Produkt> meineProdukte ...keine ChngeNotification

        //automatische ChangeNotification
        public ObservableCollection<Produkt> ProduktList { get; set; }

        private int _ProduktAnzahl;

        public event PropertyChangedEventHandler PropertyChanged;
        private void InformGUI(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        

         public Produkt AusgewaehltesProdukt { get; set; }

        public int ProduktAnzahl
        {
            get { return _ProduktAnzahl; }
            set {
                _ProduktAnzahl = value; 
                InformGUI(nameof(ProduktAnzahl));
            
            }
        }

        public void AddProdukt(Produkt neuesProdukt)
        {
            //Automatische ChangeNotification weil ObservableCollection
            ProduktList.Add(neuesProdukt);
            ProduktAnzahl = ProduktList.Count;
        }


    }
}
