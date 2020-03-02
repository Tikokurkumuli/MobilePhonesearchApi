using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Repositories
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
   
    }
}
