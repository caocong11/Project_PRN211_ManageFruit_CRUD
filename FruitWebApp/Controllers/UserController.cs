using FruitLibrary.DataAccess;
using FruitLibrary.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FruitWebApp.Controllers
{
    public class UserController : Controller
    {
        IUserRepository userRepository = null;

        public UserController() => userRepository= new UserRepository();
        // GET: UserController
        public ActionResult Index()
        {
            var user = userRepository.GetUser();
            return View(user);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var u = userRepository.GetUserbyID(id.Value);
            if(u == null)
            {
                return NotFound();
            }
            return View(u);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    userRepository.InsertUser(user);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message=ex.Message;
                return View(user);
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var u = userRepository.GetUserbyID(id.Value);
            if (u == null)
            {
                return NotFound();
            }
            return View(u);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User u)
        {
            try
            {
                if(id!=u.Id)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    userRepository.UpdateUser(u);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var u = userRepository.GetUserbyID(id.Value);
            if (u == null)
            {
                return NotFound();
            }
            return View(u);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                userRepository.DeleteUser(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
