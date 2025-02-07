using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02Demo.Sophia
{
    public class Horoscope : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string PositiveTraits { get; set; }
        public string NegativeTraits { get; set; }
        private int _rating;

        public int Rating
        {
            get => _rating;
            set
            {
                _rating = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Rating)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
