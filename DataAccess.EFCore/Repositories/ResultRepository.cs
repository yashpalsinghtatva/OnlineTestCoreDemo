using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class ResultRepository : GenericRepository<Result>, IResultRepository
    {
        public ResultRepository(OnlineTestContext context) : base(context)
        {
        }
    }
}
