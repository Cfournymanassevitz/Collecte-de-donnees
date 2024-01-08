using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ClassLibrary;
using CollecteDonnees;

namespace WpfApp1
{

    // INotifyPropertyChanged notifies the View of property changes, so that Bindings are updated.
    sealed class MyViewModel : INotifyPropertyChanged
    {
        private double _latitude;
        private double _longitude;
        private int _rayon;
        private ObservableCollection<List<LineData>> Lines { get; set; }


           
        public double Latitude
        {
            get { return _latitude; }
            set
            {
                if (_latitude != value)
                {
                    _latitude = value;
                    // If the first name has changed, the FullName property needs to be udpated as well.
                    OnPropertyChange("");
                }
            }
        }

             public double Longitude
        {
            get { return _longitude; }
            set
            {
                if (_longitude != value)
                {
                    _longitude = value;
                    // If the first name has changed, the FullName property needs to be udpated as well.
                    OnPropertyChange("");
                }
            }
        }
        public int Rayon
        {
            get { return _rayon; }
            set
            {
                if (value != _rayon)
                {
                    _rayon = value;
                }
            }
        }


        // change les propriété first name en latitude etc et supp user
      



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}