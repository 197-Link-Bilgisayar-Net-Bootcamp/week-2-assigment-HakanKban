using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    // özellikleri ayrı arayüzlere atadağımızda artık yeni katılan uçak özelliğine göre interface i kullanacak.
    interface IUcakKesif
    {
        bool KesifYap();
    } 
    interface IHedefiVur
    {
        bool HedefiVur();
    }
    class Ucaka : IUcakKesif, IHedefiVur
    {
        public bool HedefiVur()
        {
           return true;
        }

        public bool KesifYap()
        {
            return true;
        }
    }
    internal class PrensibeUyan
    {
        List<IUcakKesif> UcakKesifs;
        List<IHedefiVur> IHedefiVurs;
        // iki farklı liste oluşturduk fakat Dummy Code(sahte code) durumunu yaşamadık.
        public PrensibeUyan(List<IUcakKesif> ucakKesifs, List<IHedefiVur> ıHedefiVurs)
        {
            UcakKesifs = ucakKesifs;
            IHedefiVurs = ıHedefiVurs;
        }
        public void KesifYap()
        {
            UcakKesifs.ForEach(u => u.KesifYap());
        }  
        public void Hedef()
        {
            IHedefiVurs.ForEach(u => u.HedefiVur());
        }
    }
}
