using BuilderPattern;

var product = new ProductBuilder()
    .SetId(Guid.NewGuid())
    .SetName("Product 1")
    .SetDescription("Description of Product 1")
    .SetPrice(100)
    .SetStock(10)
    .SetCreatedAt(DateTime.Now)
    .SetUpdatedAt(DateTime.Now)
    .SetDeletedAt(DateTime.Now)
    .Build();

Console.WriteLine(product);

/*
 * Builder Pattern
 *
 * Builder pattern is a creational design pattern that lets you construct complex objects step by step.
 *
 * It separates the construction of an object from its representation
 *
 * making the same construction process able to create different representations.
 */