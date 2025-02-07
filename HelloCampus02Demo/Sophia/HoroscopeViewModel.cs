using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCampus02Demo.Sophia
{
    public class HoroscopeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Horoscope> Horoscopes { get; set; }
        private Horoscope _selectedHoroscope;

        public Horoscope SelectedHoroscope
        {
            get => _selectedHoroscope;
            set
            {
                _selectedHoroscope = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedHoroscope)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AverageRating)));
            }
        }

        public double AverageRating => Horoscopes.Any() ? Horoscopes.Average(h => h.Rating) : 0;

        public HoroscopeViewModel()
        {
            Horoscopes = new ObservableCollection<Horoscope>
            {
                new Horoscope { Name = "Krebs", ImagePath = "https://previews.123rf.com/images/cidepix/cidepix1311/cidepix131100827/23637806-illustration-von-sternzeichen-krebs-sternzeichen-auf-einem-wei%C3%9Fen-hintergrund-isoliert.jpg", Description = "Emotional und sensibel", PositiveTraits = "Fürsorglich, loyal", NegativeTraits = "Launisch, überempfindlich", Rating = 5 },
                new Horoscope { Name = "Zwilling", ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRR627tMyfRYBeQdl7GQaH5VKoQrPGOT-aJ9w&s", Description = "Intelligent und kommunikativ", PositiveTraits = "Anpassungsfähig, wissbegierig", NegativeTraits = "Unruhig, unentschlossen", Rating = 7 },
                new Horoscope { Name = "Löwe", ImagePath = "https://mim.p7s1.io/pis/ld/8c59zChLCVyZ-c1vEwXZAanB-DJ78rnq2V2gRWTHzVV6NywNWMSJCEGmZ4YSENP-WRL0b9lo2z78G9tzCuuBFLYTDP4D0LNvqKFDP5fN7M7nM3Tb67cXenQf4evHTPSFUFrowoy6Iao/profile:original?w=1200&rect=420%2C0%2C1080%2C1080", Description = "Dominant und selbstbewusst", PositiveTraits = "Großzügig, charismatisch", NegativeTraits = "Eitel, stur", Rating = 10 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
