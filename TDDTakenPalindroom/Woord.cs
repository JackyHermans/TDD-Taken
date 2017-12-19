using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTakenPalindroom
{
    public class Woord
    {
        private readonly string woord;

        public Woord(string woord)
        {
            this.woord = woord;
        }
        public bool IsPalindroom()
        {
            var andersom = new string(woord.ToArray().Reverse().ToArray());
            return woord == andersom;
        }
    }
}
