namespace Interface_Segregation
{
    // Interfaceler sınıfların anlaşmalarıdır. Haliyle bir sınıfın implement ettiği bir Interface zorunlu 
    // şekilde sınıfa uygulanır. Interface yetersiz ya da fazla ise dağıtmak gerekir. Bu prensipin mantığı budur.

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
        public class Senaryo
    {

    }
}