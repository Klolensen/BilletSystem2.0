using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Input;

namespace BilletSystem2._0
{
    public abstract class Bridge
    {
        private double _priceBil;
        private double _priceMc;
        private double _broBizz = 0.95;
        private double _weekendDiscount;

        public Bridge(double priceBil, double priceMc, double weekendDiscount)
        {
            _priceBil = priceBil;
            _priceMc = priceMc;
            _weekendDiscount = weekendDiscount;
        }

        public double PriceBil
        {
            get { return _priceBil; }
        }

        public double PriceMc
        {
            get { return _priceMc; }
        }

        public double BroBizz
        {
            get { return _broBizz; }
        }
        public double WeekendDiscount
        {
            get { return _weekendDiscount; }
        }

        public abstract string BridgeName { get; }
    }
}
