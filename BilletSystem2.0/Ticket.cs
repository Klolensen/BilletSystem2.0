using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem2._0
{
    class Ticket
    {
        private double _finalPrice;
        private DateTime _dateTime;
        private Bridge _bridge;
        private string _vehicle;
        private bool _broBizz;

        /// <summary>
        /// Enter the required information for this ticket purchase.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="bridge"></param>
        /// <param name="vehicle"></param>
        /// <param name="broBizz"></param>

        public Ticket(DateTime dateTime, Bridge bridge, string vehicle, bool broBizz)
        {
            _dateTime = dateTime;
            _bridge = bridge;
            _vehicle = vehicle;
            _broBizz = broBizz;
            _finalPrice = FindFinalPrice();
        }

        /// <summary>
        /// Return the final price of the ticket after all discounts.
        /// </summary>
        public double FinalPrice
        {
            get { return _finalPrice; }
        }

        /// <summary>
        /// Return the DateTime that is associated with this ticket.
        /// </summary>
        public DateTime DateTime
        {
            get { return _dateTime; }
        }

        /// <summary>
        /// Returns the name of the bridge associated with the ticket.
        /// </summary>
        public string Bridge
        {
            get { return _bridge.BridgeName; }
        }

        /// <summary>
        /// Returns the vehicle type that is associated with the ticket.
        /// </summary>
        public string Vehicle
        {
            get { return _vehicle; }
        }

        /// <summary>
        /// Returns whether or not a bro bizz was used for the ticket.
        /// </summary>
        public bool BroBizz
        {
            get { return _broBizz; }
        }
        private double FindFinalPrice()
        {
            double currentPrice = 0;
            if (_vehicle == "Car")
            {
                currentPrice += _bridge.PriceBil;
            }
            if (_vehicle == "MC")
            {
                currentPrice += _bridge.PriceMc;
            }
            if (_dateTime.DayOfWeek == DayOfWeek.Saturday || _dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                currentPrice *= _bridge.WeekendDiscount;
            }
            if (_broBizz)
            {
                currentPrice *= _bridge.BroBizz;
            }
            return currentPrice;
        }
    }
}
