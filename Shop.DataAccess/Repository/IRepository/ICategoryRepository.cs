﻿using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository.IRepository
{
  public interface ICategoryRepository:IRepository<Category>
    {
       void Update(Category obj);
       
    }
}
