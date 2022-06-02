using HakanKabanOdevWeek2.Core.Model;
using HakanKabanOdevWeek2.Core.Repository;
using HakanKabanOdevWeek2.Core.Service;
using HakanKabanOdevWeek2.Core.Unitofwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanKabanOdevWeek2.Service.Service
{
    public class GamesService : GenericService<Games>, IGamesService
    {
        public GamesService(IGenericRepository<Games> genericService, IUnitofwork unitofwork) : base(genericService, unitofwork)
        {
        }
    }
}
