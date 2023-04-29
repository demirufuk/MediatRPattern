using MediatR.API.Dtos;

namespace MediatR.API.Mediatr.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdDto>
    {
        public Task<GetProductByIdDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var result = new GetProductByIdDto()
            {
                Id=Guid.NewGuid(),
                Name="Laptop"
            };

            return Task.FromResult(result);

            //GetProduct from repository
        }
    }
}
