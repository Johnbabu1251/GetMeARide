using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMeRide.Repository.DbRepository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        DbCommand CreateCommand();
    }
}
