using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICandidateRepository Candidates { get; }
        ILanguageRepository Languages { get; }
        IQuestionRepository Questions { get; }
        IQuestionTypeRepository QuestionTypes { get; }
        IResultRepository Result { get; }
        IAnswerRepository Answers { get; }
        int Complete();
    }
}
