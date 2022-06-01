using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    //Prensibe Aykırı
    //Yeni bir işlem eklenmek istenirse İslemler sınıfında değişiklik yapılması gerekir.
    internal class Islemler
    {
        Toplama toplama;
        Cikarma Cikarma;

        public Islemler(Toplama toplama, Cikarma cikarma)
        {
            this.toplama = toplama;
            Cikarma = cikarma;
        }
        public void IslemiYap(IslemTipi islemTipi)
        {
            switch (islemTipi)
            {
                case IslemTipi.Toplama:
                    toplama.Islem();
                    break;
                case IslemTipi.Cikarma:
                    Cikarma.Islem();
                    break;
            }
        }
    }

    internal class Toplama
    {
        public bool Islem()
        {
            System.Console.WriteLine("Toplama işlemi.");
            return true;
        }
    }
    internal class Cikarma
    {
        public bool Islem()
        {
            System.Console.WriteLine("Çıkarma işlemi");
            return true;
        }
    }
    enum IslemTipi
    {
        Toplama,
        Cikarma

    }
}
