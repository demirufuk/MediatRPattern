namespace MediatR.API.Mediatr.Commands
{
    public class CreateCommandProduct:IRequest<Guid>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }


        public class CreateProductCommandHandler : IRequestHandler<CreateCommandProduct, Guid>
        {
            public Task<Guid> Handle(CreateCommandProduct request, CancellationToken cancellationToken)
            {
                return Task.FromResult(Guid.NewGuid());

                //createProduct from repository
            }
        }
    }
}
