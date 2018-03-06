using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem2._0
{
    class Øresund : Bridge
    {
        public Øresund() : base (410, 210, 0.8)
        {
        }

        public override string BridgeName
        {
            get { return "Øresund"; }
        }
    }
}
