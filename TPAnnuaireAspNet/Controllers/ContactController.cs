using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TPAnnuaireAspNet.Models;

namespace TPAnnuaireAspNet.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Index()
        {
            List<Contact> liste = Contact.GetContacts();
            return View(liste);
        }



        // GET: ContactController/FormContact
        public IActionResult FormContact()
        {
            return View();
        }

        // GET: ContactController/SubmitContact
        public ActionResult SubmitContact(string FirstName, string LastName, string Phone)
        {
            Contact c = new(FirstName, LastName, Phone);
            c.Save();
            return View(c);

        }

        // GET: ContactController/DisplayContact
        public IActionResult DisplayContact()
        {
        //    // renvoie du HTMl généré par Razor
            List<Contact> liste = Contact.GetContacts();

        //    // Pour partager les données entre le controlleur et la vue
        //    // 1 => Par le model de vue

        //    // 2 => ViewData
        //    // ViewData["listePersonnes"] = liste;

        //    // 3 => ViewBag
        //    //ViewBag.ListePersonnes = liste;

               return View(liste);
        }

        //public IActionResult UpdateContact(Contact contact)
        //{ 
        //    for (int i = 0; i < Contact.Liste.Count; i++)
        //    {
        //        if (contact.Id == i)
        //        {
        //            Contact.GetContactById(contact.Id);
        //        }
        //        else
        //            contact = new();
        //    }
        //    return View(Contact.Liste);
        //}

        public ActionResult UpdateContact(int id)
        {
            Contact c = new();

            return View(c);
        }


        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            List<Contact> liste = Contact.GetContactById(id);
            return View(liste);
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactController/Create
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

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactController/Edit/5
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


        public IActionResult DeleteContact(int id)
        {
            List<Contact> liste = new List<Contact>();
            liste = Contact.DeleteContact(id);
            return View(liste);
        }
    }
}
