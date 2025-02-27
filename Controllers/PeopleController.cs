using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sumedStudyGroup.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult ListPeople()
        {
            List<Models.MyClass> people = new List<Models.MyClass>();

            people.Add(new Models.MyClass { StudentNumber = "u23788918", Name = "Sumed", Surname = "Alekar", EmailAddress = "sumedalekar@gmail.com" });
            people.Add(new Models.MyClass { StudentNumber = "u23624521", Name = "Marcus", Surname = "Rivera", EmailAddress = "marcusrivera@gmail.com" });
            people.Add(new Models.MyClass { StudentNumber = "u24597729", Name = "Sophia", Surname = "Mitchell", EmailAddress = "sophiamitchell@gmail.com" });
            people.Add(new Models.MyClass { StudentNumber = "u24116514", Name = "Ethan", Surname = "Harris", EmailAddress = "ethanharris@gmail.com" });
            people.Add(new Models.MyClass { StudentNumber = "u23010523", Name = "Lily", Surname = "Parker", EmailAddress = "lilyparker@gmail.com" });

            return View(people);
        }
    }
}