using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Date.Services;
using MovieApp.Date.Static;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class CinemasController : Controller
    {
        private readonly ICinemaService _service;
        public CinemasController(ICinemaService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var date = await _service.GetAllAsync();
            return View(date);
        }

        //Get: Cinema/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Logo,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        //Get: Cinema/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);

        }

        //Get: Cinema/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaEdit = await _service.GetByIdAsync(id);

            if (cinemaEdit == null) return View("NotFound");
            return View(cinemaEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Logo,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }
        //Get: Cinema/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDelete = await _service.GetByIdAsync(id);

            if (cinemaDelete == null) return View("NotFound");
            return View(cinemaDelete);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemaDelete = await _service.GetByIdAsync(id);

            if (cinemaDelete == null) return View("NotFound");
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
