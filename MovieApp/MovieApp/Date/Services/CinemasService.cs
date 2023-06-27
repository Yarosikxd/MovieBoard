using MovieApp.Date.Base;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Date.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {
        private readonly AppDbContext _context;
        public CinemaService(AppDbContext context) : base(context) { }
    }
}
