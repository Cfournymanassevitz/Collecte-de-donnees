using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using ClassLibrary;
using CollecteDonnees;
using TestProject;

namespace WpfApp1
{

    // INotifyPropertyChanged notifies the View of property changes, so that Bindings are updated.
    sealed class MyViewModel : INotifyPropertyChanged
    {
        private double _latitude;
        private double _longitude;
        private int _rayon;
        public ObservableCollection<LineData> Lines { get; set; }



        public double Latitude
        {
            get { return _latitude; }
            set
            {
                if (_latitude != value)
                {
                    _latitude = value;
                    // If the first name has changed, the FullName property needs to be udpated as well.
                    this.NotifyPropertyChanged(nameof(Latitude));
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
                    this.NotifyPropertyChanged(nameof(Longitude));
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
                    this.NotifyPropertyChanged(nameof(Rayon));
                }
            }
        }


        // change les propriété first name en latitude etc et supp user




        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get => _addCommand ?? (_addCommand = new RelayCommand(_toExecute => ValidateCoordinates(), _canExecute => { return true; }));
            set { if (value != null) _addCommand = value; }

        }
       
        private void ValidateCoordinates()
        {

            //5.73119705178461, 45.184446886268645, 400
            BusApi busApi = new BusApi(_latitude, _longitude, _rayon);
            List<LineData> lines = busApi.GetLine();
            Lines.Clear();
            foreach (LineData lineData in lines)
            {
                Lines.Add(lineData);

            }
        }
    }
}