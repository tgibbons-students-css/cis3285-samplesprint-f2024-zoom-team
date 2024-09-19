using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class MessageController : Controller
    {
        // GET: MessageController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MessageController/Details/5
        // Changes for Sprint 1 -- As a message reading user, I want to view a list of rooms that represent conversations -- Michael Ludwig
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MessageController/Create
        // Changes for Sprint 1 -- User Story -- Briston Domino
        // Changes Sprint 1 -- As a message reading user, I want to view a list of rooms that represent conversations.
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessageController/Create
        // Changes for Sprint 1 -- As a message reading user, I want to view a list of rooms that represent conversations -- Michael Ludwig

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

        // GET: MessageController/Edit/5
        // Changes for Sprint 1 -- As a message reading user, I want to view a list of rooms that represent conversations -- Michael Ludwig
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MessageController/Edit/5
        // Changes for Sprint 2 -- User Story -- Briston Domino
        // Changes Sprint 2 -- As a system administrator, I want to serve hundreds of users concurrently.
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

        // GET: MessageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessageController/Delete/5
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
