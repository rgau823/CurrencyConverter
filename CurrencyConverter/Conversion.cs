using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    //Conversion class (model) that represents the exchange rates for currency
    //Possible functionality to add more conversionsin the future
    class Conversion
    {
        private Dictionary<string, double> conversion = new Dictionary<string, double>();

        public Conversion()
        {
            conversion["CAD"] = 1.00;
            conversion["USD"] = 0.50;
            conversion["MXN"] = 10.00;
            conversion["EURO"] = 0.25;
        }

        //Returns the conversion rate that is in the conversion dictionary
        public double getRate(string currency)
        {
            return conversion[currency];
        }

        //Returns list to populate the combo box in UI
        public List<string> getCurrs()
        {
            List<string> currs = new List<string>();
            foreach(KeyValuePair<string, double>entry in conversion)
            {
                currs.Add(entry.Key);
            }

            return currs;
        }
    }
}
