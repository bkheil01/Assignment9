using Assignment9.Models;
using Assignment9.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment9.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            BlogService service = new BlogService();
            List<Blog> blogs = service.getBlogs();
            return View(blogs);
        }

        // GET: Blog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "BlogID,Name,About,Past,Image,Favorite,Last,Date")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    BlogService service = new BlogService();
                    service.addBlog(blog);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }



        // POST: Blog/Edit/5
        public ActionResult Edit(int id)
        {
            BlogService service = new BlogService();
            BlogViewModel vm = new BlogViewModel();
            vm.Blog = service.getBlog(id);
            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "BlogID,Name,About,Image,Favorite,Last,Date")(Exclude = "Past,Past1,Past2,Past3,Past4")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    BlogService service = new BlogService();
                    service.updateBlog(blog);
                    return RedirectToAction("Index");
                }
                catch
                {
                    //failed to update
                    return View();
                }
            }
            else
            {
                //failed to update
                return View();
            }
        }

        // GET: Blog/Delete/5
        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            BlogService service = new BlogService();
            Blog blog = service.getBlog(id);
            service.removeBlog(blog);
            return RedirectToAction("Index");
        }
        // POST: Student/Delete/5
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
