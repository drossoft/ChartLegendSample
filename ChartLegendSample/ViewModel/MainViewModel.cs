using ChartLegendSample.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartLegendSample.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<ChartValue> _dataPoints;

        public MainViewModel()
        {
            DataPoints = new ObservableCollection<ChartValue>();
            DataPoints.Add(new ChartValue() { Label = "Value 1", Value = 100 });
            DataPoints.Add(new ChartValue() { Label = "Value 2", Value = 200 });
            DataPoints.Add(new ChartValue() { Label = "Value 3", Value = 300 });
            DataPoints.Add(new ChartValue() { Label = "Value 4", Value = 400 });
            DataPoints.Add(new ChartValue() { Label = "Value 5", Value = 500 });
        }
    }
}
