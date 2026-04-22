using DriveLux.Application.Features.CQRS.Queries.BrandQueries;
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
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandByIdQueryResults> Handle(GetBrandByIdQuery results)
        {
            var values = await _repository.GetByIdAsync(results.Id);
            return new GetBrandByIdQueryResults
            {
                BrandID = values.BrandID,
                Name = values.Name,
            };
        }
    }
}
