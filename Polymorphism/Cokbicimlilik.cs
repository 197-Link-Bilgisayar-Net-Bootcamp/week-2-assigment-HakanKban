using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Base
    {
        public int Id { get; set; } 
  
    }
    class Employee : Base
    {
        public string? Name { get; set; }
        public string? SurName { get; set; }
    }

    internal class Cokbicimlilik
    {
        Base b = new Employee();
        //Türemiş sınıfın refereansı türediği sınıfın referansını işaret ediyor.
        //Kalıtım veren sınıf kendisinden kalıtım alan sınıfın memberlarından haberdar değil
        


    }
}
