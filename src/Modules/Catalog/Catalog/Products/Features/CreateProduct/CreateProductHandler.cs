using Catalog.Products.Dtos;
using MediatR;
using Shared.CQRS;

namespace Catalog.Products.Features.CreateProduct;

public record CreateProductCommand(ProductDto Product) : ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);

internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
