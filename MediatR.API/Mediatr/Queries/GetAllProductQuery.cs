using MediatR.API.Dtos;

namespace MediatR.API.Mediatr.Queries
{
    public class GetAllProductQuery:IRequest<List<GetProductByIdDto>>
    {


        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductByIdDto>>
        {
            public Task<List<GetProductByIdDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model = new GetProductByIdDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Laptop"
                };

                var model2 = new GetProductByIdDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Phone"
                };

                return Task.FromResult(new List<GetProductByIdDto> { model,model2 });
            }
        }
    }
}
