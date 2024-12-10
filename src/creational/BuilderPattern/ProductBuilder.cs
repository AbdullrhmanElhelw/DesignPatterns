namespace BuilderPattern;

public class ProductBuilder : IProductBuilder
{
    private readonly Product _product = new();

    public IProductBuilder SetId(Guid id)
    {
        _product.Id = id;
        return this;
    }

    public IProductBuilder SetName(string name)
    {
        _product.Name = name;
        return this;
    }

    public IProductBuilder SetDescription(string description)
    {
        _product.Description = description;
        return this;
    }

    public IProductBuilder SetPrice(decimal price)
    {
        _product.Price = price;
        return this;
    }

    public IProductBuilder SetStock(int stock)
    {
        _product.Stock = stock;
        return this;
    }

    public IProductBuilder SetCreatedAt(DateTime createdAt)
    {
        _product.CreatedAt = createdAt;
        return this;
    }

    public IProductBuilder SetUpdatedAt(DateTime updatedAt)
    {
        _product.UpdatedAt = updatedAt;
        return this;
    }

    public IProductBuilder SetDeletedAt(DateTime deletedAt)
    {
        _product.DeletedAt = deletedAt;
        return this;
    }

    public Product Build()
    {
        return _product;
    }
}