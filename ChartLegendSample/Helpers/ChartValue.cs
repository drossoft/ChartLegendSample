using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartLegendSample.Helpers
{
    public class ChartValue
    {
        public string Label { get; set; }
        public double Value { get; set; }

        public ChartValue()
        {
            Label = string.Empty;
            Value = 0;
        }

        public ChartValue(string label, double value)
        {
            Label = label;
            Value = value;
        }
    }
}
