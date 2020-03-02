using BusinessLayer.Repositories;
using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Implementations
{
    public class MobileRepository : IMobileRepository<MobilePhone>
    {
        readonly DataContext _context;
        public MobileRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<MobilePhone> Get()
        {
            return _context.MobilePhones.ToList();
        }
    }
}
