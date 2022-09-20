using DataAccess.EFCore.Repositories;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineTestContext _context;
        public UnitOfWork(OnlineTestContext context)
        {
            _context = context;
            Candidates = new CandidateRepository(_context);
            Languages = new LanguageRepository(_context);
            Questions = new QuestionRepository(_context);
            //Questions = new QuestionRepository(_context);
            QuestionTypes = new QuestionTypeRepository(_context);
            Result = new ResultRepository(_context);
            Answers = new AnswerRepository(_context);
        }
        public ICandidateRepository Candidates { get; private set; }
        public ILanguageRepository Languages { get; private set; }
        public IQuestionRepository Questions{ get; private set; }
        public IQuestionTypeRepository QuestionTypes{ get; private set; }
        public IResultRepository Result{ get; private set; }
        public IAnswerRepository Answers{ get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
