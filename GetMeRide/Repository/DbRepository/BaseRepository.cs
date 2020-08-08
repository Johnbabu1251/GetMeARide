using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
uisng GetMeRide.Repository.DbRepository.UnitOfWork;

namespace GetMeRide.Repository.DbRepository
{
    public class BaseRepository
    {
        protected readonly IUnitOfWorkFactory unitOfWorkFactory;

        protected BaseRepository(IUnitOfWorkFactory unitOfWorkFactory)
        {
            this.unitOfWorkFactory = unitOfWorkFactory;
        }

        protected virtual async Task<DataSet> ReadFromStoredProcedure(string procedureName, SqlParameter[] parameters = null)
        {
            DataSet dataSet = new DataSet();

            using (var uow = await this.unitOfWorkFactory.Create())
            using (var command = uow.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedureName;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                var dataAdapter = new SqlDataAdapter((SqlCommand)command);
                dataAdapter.Fill(dataSet);
            }

            return dataSet;
        }
    }
}
