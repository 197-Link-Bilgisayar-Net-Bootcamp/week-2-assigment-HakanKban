using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanKabanOdevWeek2.Core.Model
{
    public class Category: BaseEntity
    {
    
        public string CategoryName { get; set; }

        //Relational property-- Bir kategoriye ait birden fazla oyun olabilir.
        public ICollection<Games> Games { get; set; }
    }
}
