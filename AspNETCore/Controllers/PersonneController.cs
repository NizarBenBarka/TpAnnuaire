using AspNETCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNETCore.Controllers
{
    public class PersonneController : Controller
    {
        // GET: PersonneController
        public ActionResult Index()
        {
            List<Personne> Liste = Personne.GetPersonne();
            return View();
        }

        // GET: PersonneController/DisplayPersonne
        public IActionResult DisplayPersonne()
        {
            //renvoi du html généré par Razor
            List<Personne> liste = Personne.GetPersonne();

            // pour partager les données  entre le controleur et  la vue
            // 1 => par le model de vue

            // 2 => par le Viewdata
            //ViewData["listePersonnes"] = liste;

            // 3 => par le ViewBag
            //ViewBag.ListePersonnes = liste;
            return View(liste);
        }

        // GET: PersonneController/Details/5
        public ActionResult Details(int id)
        {
            Personne personne = Personne.GetPersonneById(id);
            return View(personne);
        }


        // GET: PersonneController/FormPersonne
        public IActionResult FormPersonne()
        {
            return View();
        }

        // GET: PersonneController/SubmitPersonne
        public IActionResult SubmitPersonne(string Nom, string Prenom, string Telephone)
        {
            Personne p = new(Nom, Prenom ,Telephone);
            return View(p);
        }

        // GET: PersonneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonneController/Create
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

        // GET: PersonneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonneController/Edit/5
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

        // GET: PersonneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonneController/Delete/5
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
