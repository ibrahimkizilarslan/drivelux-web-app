using DriveLux.Application.Interfaces.TagCloudInterfaces;
using DriveLux.Domain.Entities;
using DriveLux.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Persistence.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {

        private readonly DriveLuxContext _context;

        public TagCloudRepository(DriveLuxContext context)
        {
            _context = context;
        }

        public List<TagCloud> GetTagCloudByBlogId(int id)
        {
            var values = _context.TagClouds.Where(x => x.BlogID == id).ToList();
            return values;
        }
    }
}
