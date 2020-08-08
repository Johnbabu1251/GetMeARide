using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMeRide.Repository.DbRepository.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly string connectionString;
        private readonly int commandTimeout;

        public UnitOfWorkFactory(string connectionString, int commandTimeout)
        {
            this.connectionString = connectionString;
            this.commandTimeout = commandTimeout;
        }

        public async Task<IUnitOfWork> Create()
        {
            var connection = new SqlConnection(this.connectionString);
            await connection.OpenAsync();

            return new AdoNetUnitOfWork(connection, this.commandTimeout);
        }
    }
}
