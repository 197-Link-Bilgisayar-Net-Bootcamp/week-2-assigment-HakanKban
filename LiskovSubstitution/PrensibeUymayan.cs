using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    // Bu senaryoda savaşa yeni uçak eklenirse ve diyelimki sadece kesif yapma özelliği olursa
    // hedefi vur özelliğini kullanmak zorunda kalır tabi bunu iş kodlarıyla düzenleyebiliriz fakat
    // prensibi çiğneriz.
    interface IUcak
    {
        bool KesifYap();
        bool HedefiVur();
    }

    public class UcakA : IUcak
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
    public class UcakB : IUcak
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
  
    internal class PrensibeUymayan
    {
        List<IUcak> Ucaklar;

        public PrensibeUymayan(List<IUcak> ucaklar)
        {
            Ucaklar = ucaklar;
        }
        public void KesifYap()
        {
            Ucaklar.ForEach(u =>
            {
                u.KesifYap();
            }); // Keşif yapan uçakları listeledim.
           
        }  
        public void HedefiVur()
        {
            Ucaklar.ForEach(u => u.HedefiVur());// Hedefi vuran uçakları listeledim.

        }
    }
}
