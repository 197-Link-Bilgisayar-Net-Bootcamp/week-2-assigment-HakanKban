using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    interface ITank
    {
        bool AtesEt();
        bool HareketEt();
    }
    internal class Tanklar : ITank
    {
        public bool AtesEt()
        {
            return true;
        }
        public bool HareketEt()
        {
            return true;
        }
    }
    internal class Tanklar2 : ITank
    {
        // bu durumda görüldüğü gibi Tank 2 nin hareket etme özelliği yoktur.
        //burada hareket et metodu dummy code durumundadır.
        public bool AtesEt()
        {
            return true;
        }

        public bool HareketEt()
        {
            return false;
        }
    }
}
