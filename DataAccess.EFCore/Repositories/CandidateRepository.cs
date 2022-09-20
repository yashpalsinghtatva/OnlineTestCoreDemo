using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>,ICandidateRepository 
    {
        public CandidateRepository(OnlineTestContext context) : base(context)
        {
        }
    }
}
