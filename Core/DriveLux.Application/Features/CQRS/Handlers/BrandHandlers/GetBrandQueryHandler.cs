using DriveLux.Application.Features.CQRS.Results.BrandResults;
using DriveLux.Application.Interfaces;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBrandQueryResults>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBrandQueryResults
            {
                BrandID = x.BrandID,
                Name = x.Name,
            }).ToList();
        }
    }
}
