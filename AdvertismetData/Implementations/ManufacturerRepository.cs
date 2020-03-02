using BusinessLayer.Repositories;
using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Implementations
{
    public class ManufacturerRepository: IManufacturerRepository<Manufacturer>
    {
        readonly DataContext _context;
        public ManufacturerRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Manufacturer> Get()
        {
            return _context.Manufacturers.ToList();
        }
    }
}
