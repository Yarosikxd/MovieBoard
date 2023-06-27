using MovieApp.Date.Base;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Date.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context) : base(context)
        {

        }
    }
}
