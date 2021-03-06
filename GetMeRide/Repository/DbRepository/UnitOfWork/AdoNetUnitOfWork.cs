﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMeRide.Repository.DbRepository.UnitOfWork
{
    public class AdoNetUnitOfWork : IUnitOfWork
    {
        private IDbConnection connection;
        private readonly int commandTimeout;

        public AdoNetUnitOfWork(IDbConnection connection, int commandTimeout)
        {
            this.connection = connection;
            this.commandTimeout = commandTimeout;
        }

        public DbCommand CreateCommand()
        {
            var command = this.connection.CreateCommand();
            command.CommandTimeout = this.commandTimeout;

            return command as DbCommand;
        }

        public void Dispose()
        {
            if (this.connection != null)
            {
                this.connection.Close();
                this.connection = null;
            }
        }
    }
}
