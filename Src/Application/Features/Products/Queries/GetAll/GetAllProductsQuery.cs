using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Queries.GetAll
{
    public class GetAllProductsQuery : RequestParametersBasic, IRequest<PaginationResponse<ProductDto>>, ICacheQuery
    {
        public int? BrandId { get; set; }
        public int? TypeId { get; set; }

        public int HoursSaveData => 1; //1 hour save data 
    }
}
