using Microsoft.EntityFrameworkCore;
using DriveLux.Application.Interfaces.BlogInterfaces;
using DriveLux.Domain.Entities;
using DriveLux.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly DriveLuxContext _context;

        public BlogRepository(DriveLuxContext context)
        {
            _context = context;
        }

        public List<Blog> GetAllBlogsWithAuthors()
        {
            var values = _context.Blogs.Include(x => x.Author).ToList();
            return values;
        }

        public List<Blog> GetBlogByAuthorId(int id)
        {
            var values = _context.Blogs.Include(x => x.Author).Where(y => y.BlogID == id).ToList();
            return values;
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values = _context.Blogs.Include(x => x.Author).OrderByDescending(x => x.BlogID).Take(3).ToList();
            return values;
        }
    }
}
