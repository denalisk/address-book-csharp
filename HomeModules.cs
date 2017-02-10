using Nancy;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
        Get["/"] = _ =>
        {
            return View["index.cshtml"];
        }

        Get["/add"] = _ =>
        {
            return View["forms.cshtml"];
        }
      // GETs and POSTs go HERE = _ =>
    }
  }
}
