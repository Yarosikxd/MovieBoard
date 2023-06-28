using MovieApp.Date.Base;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Date.Services
{
    public interface IShoppingCartItemService : IEntityBaseRepository<ShoppingCartItem>
    {
        Task AddAsync(Movie movie);
    }
}
