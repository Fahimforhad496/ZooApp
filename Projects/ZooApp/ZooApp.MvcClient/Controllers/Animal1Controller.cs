using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooApp.Services;
using ZooApp.ViewModels;

namespace ZooApp.MvcClient.Controllers
{
    public class Animal1Controller : Controller
    {
        AnimalService service = new AnimalService();
        // GET: Animal1
        public ActionResult Index()
        {
           
            var viewAnimals = service.GetAnimals();
            return View(viewAnimals);

        }

        public ActionResult Details(int id)
        {
           ViewAnimal animal = service.GetAnimal(id);
            return View(animal);
        }
    }
}