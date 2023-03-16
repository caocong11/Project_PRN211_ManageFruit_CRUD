using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FruitLibrary.DataAccess;
using FruitLibrary.Repository;

namespace FruitWebApp.Controllers
{
    public class FruitController : Controller
    {
        IFruitRepository fruitRepsitory = null;
        public FruitController() => fruitRepsitory = new FruitRepository();
        // GET: FruitController
        public ActionResult Index()
        {
            var fruit = fruitRepsitory.GetFruits();
            return View(fruit);
        }
        [HttpPost]
        public ActionResult Index(string searchTerm)
        {
            var fruit = fruitRepsitory.GetFruits().Where(x=>x.FruitName.Contains(searchTerm));
            if (searchTerm == null)
            {
                fruit = fruitRepsitory.GetFruits();
            }
            return View(fruit);
        }

        // GET: FruitController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var fr = fruitRepsitory.GetFruitbyID(id.Value);
            if(fr == null)
            {
                return NotFound();
            }
            return View(fr);
        }

        // GET: FruitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FruitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fruit fr)
        {
            try
            {
                if(ModelState.IsValid) {
                    fruitRepsitory.InsertFruit(fr);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message=ex.Message;
                return View(fr);
            }
        }

        // GET: FruitController/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var fr = fruitRepsitory.GetFruitbyID(id.Value);
            if(fr == null)
            {
                return NotFound();
            }
            return View(fr);
        }

        // POST: FruitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Fruit fr)
        {
            try
            {
                if (id != fr.Id)
                {

                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    fruitRepsitory.UpdateFruit(fr);
                }
                return RedirectToAction(nameof(Index));
            }
            
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: FruitController/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var fr = fruitRepsitory.GetFruitbyID(id.Value);
            if(fr == null)
            {
                return NotFound();
            }
            return View(fr);
        }

        // POST: FruitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                fruitRepsitory.DeleteFruit(id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
