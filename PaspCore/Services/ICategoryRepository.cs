﻿using PaspCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Services
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
