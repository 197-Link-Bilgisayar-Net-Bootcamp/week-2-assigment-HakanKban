using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    //High Level Class
    class Imalat
    {
        //Kek sınıfındaki değşiklik Olustur metodunu etkliyecektir.
        public void Olustur()
        {
            Kek kek = new Kek();
            kek.KekYap(true);
        }
    }
    //Low Level Class
    class Kek
    {
        public void KekYap(bool Kakao)
        {

        }
    }


    internal class BagimlilikSenaryosu
    {
    }
}
