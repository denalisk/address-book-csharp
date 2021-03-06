using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;
using System;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
        Get["/"] = _ =>
        {
            return View["contact-list.cshtml", Book.GetContactList()];
        };
        Get["/add"] = _ =>
        {
            return View["forms.cshtml"];
        };
        Get["/contact/{id}"] = parameter =>
        {
            Contact selectedContact = Book.GetContact(parameter.id);
            return View["contact.cshtml", selectedContact];
        };
        Get["/clear"] = _ =>
        {
            return View["clear.cshtml"];
        };
        Post["/search"] = _ =>
        {
            string query = Request.Form["query"];
            List<Contact> result = Book.NameSearch(query);
            return View["search-results.cshtml", result];
        };
        Post["/contacts/clear"] = _ =>
        {
            Book.ClearContacts();
            return View["contact-list.cshtml", Book.GetContactList()];
        };
        Post["/delete/{id}"] = parameter =>
        {
            if (Book.GetContactDictionary().ContainsKey(parameter.id))
            {
                Contact selectedContact = Book.GetContact(parameter.id);
                Book.DeleteContact(selectedContact);
            }
            return View["contact-list.cshtml", Book.GetContactList()];
        };
        Post["contact/new"] = _ =>
        {
            string newName = Request.Form["new-name"];
            string newPhoneNumber = Request.Form["new-phone-number"];
            string newStreetAddress = Request.Form["new-street-address"];
            string newCity = Request.Form["new-city"];
            string newState = Request.Form["new-state"];
            string newEmail = Request.Form["new-email"];
            Address newAddress = new Address(newStreetAddress, newCity, newState);
            Contact newContact = new Contact(newName, newPhoneNumber, newAddress, newEmail);
            Book.SaveContact(newContact);
            return View["contact-new.cshtml", newContact];
        };

      // GETs and POSTs go HERE = _ =>
    }
  }
}
