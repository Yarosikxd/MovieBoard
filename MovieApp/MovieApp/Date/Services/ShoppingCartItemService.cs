using MovieApp.Date.Base;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Date.Services
{
    public class ShoppingCartItemService : EntityBaseRepository<ShoppingCartItem>, IShoppingCartItemService
    {
        private readonly AppDbContext _context;
        public ShoppingCartItemService (AppDbContext context) : base(context) { }

        public async Task AddAsync(Movie movie)
        {
           
        }
        //public async Task AddNewMovieAsync(NewMovieVM data)
        //{
        //    var newMovie = new Movie()
        //    {
        //        Name = data.Name,
        //        Description = data.Description,
        //        Price = data.Price,
        //        ImageURL = data.ImageURL,
        //        CinemaId = data.CinemaId,
        //        StarttDate = data.StartDate,
        //        EndDate = data.EndDate,
        //        MovieCategory = data.MovieCategory,
        //        ProducerId = data.ProducerId
        //    };
        //    await _context.Movies.AddAsync(newMovie);
        //    await _context.SaveChangesAsync();

        //    //Add Movie Actors
        //    foreach (var actorId in data.ActorIds)
        //    {
        //        var newActorMovie = new Actor_Movie()
        //        {
        //            MovieId = newMovie.Id,
        //            ActorId = actorId
        //        };
        //        await _context.Actors_Movies.AddAsync(newActorMovie);
        //    }
        //    await _context.SaveChangesAsync();


        //}
    }
}
