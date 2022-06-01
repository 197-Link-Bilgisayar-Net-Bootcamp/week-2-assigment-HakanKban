using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class Futbolcu2
    {
        public string? FutbolcuAdi { get; set; }
        public string? FutbolcuYasi { get; set; }
    }
    // Classlar ayrılarak hepsi kendi içlerinde yapması gereken işe odaklanmıştır.
    internal class GolKontrol
    {
        public bool GolMu()
        {
            return false;
        }
    }
    internal class KaleciKontrol
    {
        public bool KaleciMi()
        {
            return true;
        }
    }
}
