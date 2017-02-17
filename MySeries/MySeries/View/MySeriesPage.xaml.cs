using MySeries.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MySeries.View
{
    public partial class MySeriesPage : ContentPage
    {
        public MySeriesPage()
        {
            InitializeComponent();

            BindingContext = new SeriesViewModel();
        }
    }
}
