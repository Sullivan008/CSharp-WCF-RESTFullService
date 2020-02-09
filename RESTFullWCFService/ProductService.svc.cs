using RESTFullWCFService.Models;
using RESTFullWCFService.Operations.Fruit;
using System;
using System.Collections.Generic;

namespace RESTFullWCFService
{
    public class ProductService : IProductService
    {
        public List<Fruit> GetAllProducts() =>
            new FruitOperations().GetFruits();

        public string PutProductData(Fruit fruit)
        {
            if (fruit == null)
            {
                throw new ArgumentNullException(nameof(fruit));
            }

            return "Data obtained from the client: " +
                "Id: " + fruit.Id + " Name: " + fruit.Name + " Price: " + fruit.Price;
        }
    }
}
