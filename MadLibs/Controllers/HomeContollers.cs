using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form() { return View(); }

        [Route("/madLibStory")]
        public ActionResult MadLib(string verb1, string noun1, string adj1, string verb2, string noun2)
        {
            MadLibWords newMadLib = new MadLibWords();
            newMadLib.Verb1 = verb1;
            newMadLib.Noun1 = noun1;
            newMadLib.Adj1 = adj1;
            newMadLib.Verb2 = verb2;
            newMadLib.Noun2 = noun2;
            return View(newMadLib);
        }
    }
}
