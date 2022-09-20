using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class LanguageRepository : GenericRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(OnlineTestContext context) : base(context)
        {

        }
    }
}
