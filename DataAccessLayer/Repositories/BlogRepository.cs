﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using var context = new Context();
            context.Blogs.Add(blog);
            context.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var context = new Context();
            context.Blogs.Remove(blog);
            context.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var context = new Context();
            return context.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var context = new Context();
            return context.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var context = new Context();
            context.Blogs.Update(blog);
            context.SaveChanges();
        }
    }
}
