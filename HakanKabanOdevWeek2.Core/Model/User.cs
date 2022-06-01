using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanKabanOdevWeek2.Core.Model
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public DateTime MembershipDate { get; set; }

        public int CountGame { get; set; }

        //Many to Many Relational Property
        public ICollection<UserGames> UserGames { get; set; }

    }
}
