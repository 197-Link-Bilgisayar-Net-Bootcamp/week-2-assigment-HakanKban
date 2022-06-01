using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanKabanOdevWeek2.Core.Model
{
    public class Games : BaseEntity
    {
        public string GamesName { get; set; }
        public int DownloadCounts { get; set; }

        // Relational Properties--- Bir oyunun tek bir kategorisi vardır.
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //Many to Many Relational Property
        public ICollection<UserGames> UserGames { get; set; }

    }
}
