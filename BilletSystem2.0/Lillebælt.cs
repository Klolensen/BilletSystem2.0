using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem2._0
{
    class Lillebælt : Bridge
    {
        public Lillebælt() : base (240, 125, 1)
        {
        }

        public override string BridgeName
        {
            get { return "Lillebælt"; }
        }
    }
}
