using BlogAlkemy.Models;
using BlogAlkemy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogAlkemy.Controllers
{
    public class BlogPostController : Controller
    {
        private BlogPostRepositorio _repo;

        public BlogPostController()
        {
            _repo = new BlogPostRepositorio();
        }

        // GET: BlogPost
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }

        // GET: BlogPost/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogPost/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: BlogPost/Create
        [HttpPost]
        public ActionResult Create(Blog model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Crear(model);
                    return RedirectToAction("Index");
                }
                // TODO: Add insert logic here

            }
            catch(Exception ex)
            {
                
            }

            return View(model);
        }

        // GET: BlogPost/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogPost/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogPost/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogPost/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
