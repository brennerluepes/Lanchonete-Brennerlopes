

Controller: LanchesController.cs
using System.Collections.Generic;
using System.Web.Mvc;
using LanchoneteMVC.Models;
namespace LanchoneteMVC.Controllers
{
    public class LanchesController : Controller
    {
        private static List<Lanche> lanches = new List<Lanche>();
        public ActionResult Index()
        {
            return View(lanches);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Lanche lanche)
        {
            if (ModelState.IsValid)
            {
                lanche.Id = lanches.Count + 1;
                lanches.Add(lanche);
                return RedirectToAction("Index");
            }
            return View(lanche);
        }
    }
}