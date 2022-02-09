using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project1.Models;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        

        private TasksContext tContext { get; set; }

        public HomeController(TasksContext localContext)
        {
            tContext = localContext;
        }

        public IActionResult Index()
        {
            var tasks = tContext.Tasks
                .Include(x => x.Category)
                .Where(x => x.Completed == false)
                .ToList();

            return View(tasks);
        }

        public IActionResult MarkComplete(int taskid)
        {
            var task = tContext.Tasks
                .Single(x => x.TaskID == taskid);

            task.Completed = true;

            tContext.Update(task);
            tContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Categories = tContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddTask(TasksModel tm)
        {
            if (ModelState.IsValid)
            {
                tContext.Add(tm);
                tContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Categories = tContext.Categories.ToList();

                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int taskid)
        {
            ViewBag.Categories = tContext.Categories.ToList();

            var task = tContext.Tasks
                .Single(x => x.TaskID == taskid);

            return View("AddTask", task);
        }

        [HttpPost]
        public IActionResult Edit(TasksModel tm)
        {
            tContext.Update(tm);
            tContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteTask(int taskid)
        {
            var task = tContext.Tasks
                .Single(x => x.TaskID == taskid);

            return View(task);
        }

        [HttpPost]
        public IActionResult DeleteTask(TasksModel tm)
        {
            tContext.Tasks.Remove(tm);
            tContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
