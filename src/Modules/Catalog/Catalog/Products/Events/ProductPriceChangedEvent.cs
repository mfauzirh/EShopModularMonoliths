namespace Catalog.Products.Events;

public record ProductPriceChanged(Product Product) : IDomainEvent;
