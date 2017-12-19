using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTakenVeiling
{
    public class Veiling
    {
        private decimal hoogsteBod;
        public void DoeBod(decimal bedrag)
        {
            if (bedrag > hoogsteBod)
            {
                hoogsteBod = bedrag;
            }
        }
        public decimal HoogsteBod
        {
            get
            {
                return hoogsteBod;
            }
        }
    }
}
