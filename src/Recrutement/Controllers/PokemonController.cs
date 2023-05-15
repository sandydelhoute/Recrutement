using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recrutement.Services.Interfaces;
using Recrutement.Services.Services;

namespace Recrutement.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonService pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            this.pokemonService = pokemonService;
        }
        // GET: Pokemon
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pokemon/Details/5
        public ActionResult Details(int id)
        {
            return new JsonResult(this.pokemonService.GetById(id));
        }

        // GET: Pokemon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pokemon/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pokemon/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pokemon/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pokemon/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pokemon/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
