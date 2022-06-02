using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakanKabanOdevWeek2.Core.Unitofwork
{
    public  interface IUnitofwork
    {
        Task CommitAsync();
        void Commit();
    }
}
