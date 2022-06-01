using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanKabanOdevWeek2.Core.Model
{
    public  class UserGames
    {
        //Chansing Table--- Senaryo gereği kullanıcılar ve oyunlar arasında many to many ilişki vardır.
        public int UserId { get; set; }
        public int GamesId { get; set; }
        public User User { get; set; }
        public Games Games { get; set; }

    }
}
