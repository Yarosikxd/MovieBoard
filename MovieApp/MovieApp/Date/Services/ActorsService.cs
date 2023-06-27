using MovieApp.Date.Base;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Date.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
