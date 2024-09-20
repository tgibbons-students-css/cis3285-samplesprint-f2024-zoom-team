using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


// Changes for Sprint #2 -- User Story 2D -- Mikita Puntus
// Changes Sprint 2D -- As a system admin, I want to be able to set a limit to the number of users in any one room. -- Mikita Puntus

/// <summary>
/// Developer: Mikita Puntus
/// in Controllers: public class RoomController : Controller
///   public ActionResult Create(IFormCollection collection)
///   public ActionResult Edit(int id, IFormCollection collection)
/// </summary>

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class RoomController : Controller
    {
        // GET: RoomController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoomController/Details/5
        // Changes for Sprint 1 -- User Story -- Michael Ludwig
        // Changes Sprint 1 -- As a message posting user, I want to create rooms for categorizing conversations -- Michael Ludwig
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoomController/Create
        // Changes for Sprint 1 -- User Story -- Michael Ludwig
        // Changes Sprint 1 -- As a message posting user, I want to create rooms for categorizing conversations -- Michael Ludwig
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomController/Create

        // Changes for Sprint 2 -- User Story -- Mikita Puntus
        // Changes Sprint 2D -- As a system admin, I want to be able to set a limit to the number of users in any one room. -- Mikita Puntus
        // Made some chamges
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        // Changes for Sprint 1 -- User Story -- Michael Ludwig
        // Changes Sprint 1 -- As a message posting user, I want to create rooms for categorizing conversations -- Michael Ludwig
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomController/Edit/5

        // Changes for Sprint 2 -- User Story -- Mikita Puntus
        // Changes Sprint 2D -- As a system admin, I want to be able to set a limit to the number of users in any one room. -- Mikita Puntus
        // Made some chamges
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        // Changes for Sprint 1 -- User Story -- Michael Ludwig
        // Changes Sprint 1 -- As a message posting user, I want to create rooms for categorizing conversations -- Michael Ludwig
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
