using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    interface IGida
    {
        void Yap(bool kakao);
    }
    //High Level Class--- Referans olarak interface kulanddığından dolaylı olarak bağımlılık alt seviyeden üst seviyeye olmuştur.
    class Imalatt
    {
        IGida gida;

        public Imalatt(IGida gida)
        {
            this.gida = gida;
        }

        public void Olustur()
        {
            gida.Yap(false);
        }
    }
    //Low Level Class --- Görüldüğü gibi alt seviye sınıf interface bağımlı hale gelmiştir.
    class Kekk : IGida
    {
        public void Yap(bool kakao)
        {

        }
    }
    internal class BagimlilikTersSenaryosu
    {
    }
}
