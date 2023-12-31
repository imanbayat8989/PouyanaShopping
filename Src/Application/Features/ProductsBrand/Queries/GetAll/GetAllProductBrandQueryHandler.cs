﻿using Application.Contracts;
using Domain.Entities.ProductEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProductsBrand.Queries.GetAll
{
    public class GetAllProductBrandQueryHandler : IRequestHandler<GetAllProductBrandQuery, IEnumerable<ProductBrand>>
    {
        private readonly IUnitOWork _uow;

        public GetAllProductBrandQueryHandler(IUnitOWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<ProductBrand>> Handle(GetAllProductBrandQuery request,
            CancellationToken cancellationToken)
        {
            var spec = new ProductBrandSpec();
            return await _uow.Repository<ProductBrand>().ListAsyncSpec(spec, cancellationToken);
            // return await _uow.Repository<ProductBrand>().GetAllAsync(cancellationToken);
        }
    }
}
