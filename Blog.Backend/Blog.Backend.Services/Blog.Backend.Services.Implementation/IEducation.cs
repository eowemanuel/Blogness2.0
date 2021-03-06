﻿using System.Collections.Generic;
using Blog.Backend.Common.Contracts;

namespace Blog.Backend.Services.Implementation
{
    public interface IEducation
    {
        List<Education> GetByUser(int userId);
        bool Add(Education education);
        bool Update(Education education);
        bool Delete(int educationId);
    }
}
