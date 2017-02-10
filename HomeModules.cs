using Nancy;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
        Get["/"] = _ =>
        {
            return View["index.cshtml"];
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
            return View["contact.cshtml", newContact];
        };
      // GETs and POSTs go HERE = _ =>
    }
  }
}
