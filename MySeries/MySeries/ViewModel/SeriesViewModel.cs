using MySeries.Model;
using System.Collections.Generic;
using System.ComponentModel;

namespace MySeries.ViewModel
{
    public class SeriesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Series> _series;
        public List<Series> Series
        {
            get { return _series; }
            set
            {
                _series = value;
                OnPropertyChanged("Series");
            }
        }

        public SeriesViewModel()
        {
            Series = new List<Series>();
            LoadSeries();
        }

        private void LoadSeries()
        {
            Series = new List<Series>()
            {
                new Series()
                {
                    Name = "Game of Thrones",
                    Description = "HBO"
                },
                new Series()
                {
                    Name = "Black Mirror",
                    Description = "Netflix"
                },
                new Series()
                {
                    Name = "Breaking bad",
                    Description = "AMC"
                }
            };
        }
    }
}
