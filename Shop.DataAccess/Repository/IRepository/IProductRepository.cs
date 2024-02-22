﻿using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository.IRepository
{
  public interface IProductRepository:IRepository<Product>
    {
       void Update(Product obj);
       
    }
}
