using Microsoft.AspNetCore.Mvc;
using MovieApp.Date;
using MovieApp.Date.Services;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class ShoppingCartItemController : Controller
    {
        private readonly IShoppingCartItemService _service;
        public ShoppingCartItemController(IShoppingCartItemService service)
        {
            _service = service;
        }
        
        public async Task<IActionResult> Index()
        {
            var date = await _service.GetAllAsync();
            return View(date);
        }
        //Get: Actor/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Movie")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }
            await _service.AddAsync(movie);
            return RedirectToAction(nameof(Index));
        }

    }
}
