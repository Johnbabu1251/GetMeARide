using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMeRide.Repository.DbRepository.UnitOfWork
{
    public class IUnitOfWorkFactory
    {
        Task<IUnitOfWork> Create();
    }
}
