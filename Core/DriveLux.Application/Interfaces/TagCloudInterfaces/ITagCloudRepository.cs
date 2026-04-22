using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Interfaces.TagCloudInterfaces
{
    public interface ITagCloudRepository
    {
        List<TagCloud> GetTagCloudByBlogId(int id);
    }
}
