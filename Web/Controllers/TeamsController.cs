using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{   
    public class TeamsController : Controller
    {
		private readonly ITeamRepository teamRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public TeamsController() : this(new TeamRepository())
        {
        }

        public TeamsController(ITeamRepository teamRepository)
        {
			this.teamRepository = teamRepository;
        }

        //
        // GET: /Teams/

        public ViewResult Index()
        {
            return View(teamRepository.All);
        }

        //
        // GET: /Teams/Details/5

        public ViewResult Details(int id)
        {
            return View(teamRepository.Find(id));
        }

        //
        // GET: /Teams/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Teams/Create

        [HttpPost]
        public ActionResult Create(Team team)
        {
            if (ModelState.IsValid) {
                teamRepository.InsertOrUpdate(team);
                teamRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Teams/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(teamRepository.Find(id));
        }

        //
        // POST: /Teams/Edit/5

        [HttpPost]
        public ActionResult Edit(Team team)
        {
            if (ModelState.IsValid) {
                teamRepository.InsertOrUpdate(team);
                teamRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Teams/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(teamRepository.Find(id));
        }

        //
        // POST: /Teams/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            teamRepository.Delete(id);
            teamRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

