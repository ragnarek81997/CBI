﻿using CBI.Domain.Interfaces.Infrastructure;
using CBI.Domain.Entities.Infrastructure;
using CBI.Domain.Entities.Models;
using CBI.Domain.Interfaces;

namespace CBI.Infrastructure.Data
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
