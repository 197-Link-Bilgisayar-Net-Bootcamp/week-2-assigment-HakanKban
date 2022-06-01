using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{

    //Burada ise arayüz sayesinde sınıfı genişletip,değişikliği önlüyoruz.
    public interface Islem
    {
        bool Islem();
    }
    public class Toplam : Islem
    {
        public bool Islem()
        {
            System.Console.WriteLine("Toplam");
            return true;
        }
    }
    public class Cikar : Islem
    {
        public bool Islem()
        {
            System.Console.WriteLine("Çıkar");
            return true;
        }
    }
    internal class Islemler2
    {
        Islem islem;

        public Islemler2(Islem islem)
        {
            this.islem = islem;
        }
        public void IslemiYap()
        {
            islem.Islem();
        }
    }
}
