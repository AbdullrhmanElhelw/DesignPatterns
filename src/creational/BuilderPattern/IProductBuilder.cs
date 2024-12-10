namespace BuilderPattern;

public interface IProductBuilder : IBuilder<Product>
{
    public IProductBuilder SetId(Guid id);

    public IProductBuilder SetName(string name);

    public IProductBuilder SetDescription(string description);

    public IProductBuilder SetPrice(decimal price);

    public IProductBuilder SetStock(int stock);

    public IProductBuilder SetCreatedAt(DateTime createdAt);

    public IProductBuilder SetUpdatedAt(DateTime updatedAt);

    public IProductBuilder SetDeletedAt(DateTime deletedAt);
}