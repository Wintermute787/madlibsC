using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Landing()
    {
      return View();
    }

    [Route("/libs")]
    public ActionResult Libs()
    {
      return View();
    }

    [Route("/about")]
    public ActionResult About()
    {
      return View();
    }

    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/madlib")]
    public ActionResult MadLib(string name, string adjective, string noun)
    {
      Libbles newLibble = new Libbles();
      newLibble.SetName(name);
      newLibble.SetAdjective(adjective);
      newLibble.SetNoun(noun);
      return View(newLibble);
    }
  }
}
