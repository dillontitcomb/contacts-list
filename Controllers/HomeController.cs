using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
						List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }
				[HttpGet("/add-contact")]
				public ActionResult ContactForm()
				{
						return View();
				}
				[HttpPost("/")]
				public ActionResult AddContact()
				{
						Contact newContact = new Contact (Request.Form["name"], (Request.Form["phone"]), Request.Form["email"]);
						List<Contact> allContacts = Contact.GetAll();
						return View("Index", allContacts);
				}
		}
}
