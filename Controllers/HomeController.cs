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
						Address newAddress = new Address (Request.Form["street"], Request.Form["city"], Request.Form["state"], int.Parse(Request.Form["zip"]));
						newContact.SetAddress(newAddress);
						List<Contact> allContacts = Contact.GetAll();
						return View("Index", allContacts);
				}
				[HttpGet("/{id}")]
				public ActionResult Details(int id)
				{
					Contact contact = Contact.Find(id);
					return View(contact);
				}

				[HttpPost("/clear-contacts")]
				public ActionResult ClearContacts()
				{
						Contact.ClearAll();
						List<Contact> allContacts = Contact.GetAll();
						return View("Index", allContacts);
				}
		}
}
