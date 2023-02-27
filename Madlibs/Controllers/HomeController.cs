using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/")]
        public ActionResult Madlib()
        {
            MadlibVariable myMadlibVariable = new MadlibVariable();
            myMadlibVariable.Noun = "Turtle";
            myMadlibVariable.PluralNoun = "Turtles";
            return View(myMadlibVariable);
        }

        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/madlibform")]
        public ActionResult MadlibForm(string noun, string pluralnoun, string noun2, string place, string adjective, string noun3)
        {
            MadlibVariable myMadlibVariable = new MadlibVariable();
            myMadlibVariable.Noun = noun;
            myMadlibVariable.PluralNoun = pluralnoun;
            myMadlibVariable.Noun2 = noun2;
            myMadlibVariable.Place = place;
            myMadlibVariable.Adjective = adjective;
            myMadlibVariable.Noun3 = noun3;
            return View(myMadlibVariable);
        }

    }
}