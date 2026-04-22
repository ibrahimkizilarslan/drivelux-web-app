using DriveLux.Application.Features.CQRS.Queries.BannerQueries;
using DriveLux.Application.Features.CQRS.Results.BannerResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResults> Handle(GetBannerByIdQuery results)
        {
            var values = await _repository.GetByIdAsync(results.Id);
            return new GetBannerByIdQueryResults
            {
                BannerId = values.BannerId,
                Description = values.Description,
                Title = values.Title,
                VideoDescription = values.VideoDescription,
                VideoUrl = values.VideoUrl,
            };
        }
    }
}
