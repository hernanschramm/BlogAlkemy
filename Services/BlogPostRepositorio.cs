using BlogAlkemy.Data;
using BlogAlkemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAlkemy.Services
{
    public class BlogPostRepositorio
    {
        public List<Blog> ObtenerTodos()
        {
            using (var db = new AppDBContext())
            {
                return db.Blog.ToList();
            }


        }

        internal void Crear(Blog model)
        {
            using (var db=new AppDBContext())
            {
                db.Blog.Add(model);
                db.SaveChanges();
            }
        }
    }
}