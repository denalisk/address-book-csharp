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
        Post["/new-contact"] = _ =>
        {
            string newName = Request.Form["new-name"];
            int newPhoneNumber = Request.Form["new-phone-number"];
            string newStreetAddress = Request.Form["new-street-address"];
            string newCity = Request.Form["new-city"];
            string newState = Request.Form["new-state"];
            Address newAddress = new Address(newStreetAddress, newCity, newState);
            Contact newContact = new Contact(newName, newPhoneNumber, newAddress);
            Book.SaveContact(newContact);
            return View["contact.cshtml", newContact];
        };
      // GETs and POSTs go HERE = _ =>
    }
  }
}
