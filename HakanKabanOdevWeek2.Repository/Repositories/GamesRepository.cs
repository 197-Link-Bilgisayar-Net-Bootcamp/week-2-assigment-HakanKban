using HakanKabanOdevWeek2.Core.Model;
using HakanKabanOdevWeek2.Core.Repository;
using HakanKabanOdevWeek2.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanKabanOdevWeek2.Repository.Repositories
{
    public class GamesRepository : GenericRepository<Games>, IGamesRepository
    {
        public GamesRepository(MyContext context) : base(context)
        {
        }
    }
}
