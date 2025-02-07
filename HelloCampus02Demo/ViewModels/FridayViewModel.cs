using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HelloCampus02Demo.ViewModels
{
    public delegate void MyDummyMitIntParameter(int x);
    internal class FridayViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private int _SliderValue;

        public int SliderValue
        {
            get { return _SliderValue; }
            set { 
                _SliderValue = value; 
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(SliderValue)));
                }
            }
        }


        #region Wiederholung Delegate und Lambdas
        public void Hello(int wieOftFrageZeichen)
        {

        }
        public void GoodBye(int test)
        {
            for (int i = 0; i < test; i++)
            {
                MessageBox.Show("Tschüss");
            }
        }
        public void Heute(int test)
        {
                MessageBox.Show(System.DateTime.Now.ToShortDateString());
            
        }
        public void dummy()
        {
            MyDummyMitIntParameter meinDelegate = 
                new MyDummyMitIntParameter(Hello);

            Hello(12);
            meinDelegate(12);
            IchBinGenerischUndBrauchLogik(einInt =>
            {
                //Lambda
                MessageBox.Show("Hallo Welt - die zahl ist " +einInt  );
            }, 37);


            IchBinGenerischUndBrauchLogik(Heute, 9);
            IchBinGenerischUndBrauchLogik(meinDelegate,3);
            IchBinGenerischUndBrauchLogik(GoodBye, 4);

        }

        public void IchBinGenerischUndBrauchLogik(MyDummyMitIntParameter dieLogik, int x)
        {
            //Action
            //Variante A
            //Variante B
            //Variante C
            dieLogik(x);
            //Action

        }
        #endregion


    }
}
