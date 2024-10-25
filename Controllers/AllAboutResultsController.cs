using System;
using Microsoft.AspNetCore.Mvc;

namespace IntheBag.Controllers
{
    public class AllAboutResults : Controller
    {
        public IActionResult Index()
        {
            var weekday = DateTime.Now.DayOfWeek;
            var day = weekday.ToString();
            var time = DateTime.Now.Hour;

            if (time < 6)
            {
                ViewBag.Greeting = "It is too early to be up!";
            }
            else if (time < 12)
            {
                ViewBag.Greeting = "Good Morning";
            }
            else if (time < 18)
            {
                ViewBag.Greeting = "Good Afternoon";
            }
            else
            {
                ViewBag.Greeting = "Good Evening";
            }

            int route = 0;

            switch (day)
            {
                case "Monday":
                    ViewBag.DayMessage = "The work week just started! Stay focused, you have a lot to do this week!";
                    route = 1;
                    break;
                case "Tuesday":
                    ViewBag.DayMessage = "Halfway to the weekend!";
                    route = 2;
                    break;
                case "Wednesday":
                    ViewBag.DayMessage = "Isn't it Friday somewhere?";
                    route = 3;
                    break;
                case "Thursday":
                    ViewBag.DayMessage = "Whoo hoo TGIF!";
                    route = 4;
                    break;
                case "Friday":
                    ViewBag.DayMessage = "Ahhhh... the weekend!";
                    route = 5;
                    break;
                default:
                    ViewBag.DayMessage = "Ahhhh... the weekend!";
                    route = 5;
                    break;
            }

            if (route == 1)
            {
                return RedirectToAction("Weekday", "AllAboutResults");
            }
            else if (route == 2 || route == 3)
            {
                return Redirect("https://lisabach.com/CIT218/Chapter8/HappyWednesday.html");
            }
            else
            {
                return View();
            }

        }
        public IActionResult Weekday()
        {
            ViewBag.Greeting = "Congratulations, the work week just started and you have been rerouted!";
            return View();
        }
    }
}
