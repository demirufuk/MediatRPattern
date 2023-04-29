using MediatR.API.Dtos;

namespace MediatR.API.Mediatr.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductByIdDto>
    {
        public Guid Id { get; set; }
    }
}
