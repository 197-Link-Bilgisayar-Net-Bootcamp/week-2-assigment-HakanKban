using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{   //Prensibe aykırı davranış.
    internal class Futbolcu
    {
        public string? FutbolcuAdi { get; set; }
        public string? FutbolcuYasi { get; set; }

        public bool KaleciMi()
        {
            return true;
        }
        public bool GolMu()
        {
            return false;
        }

    }
}
