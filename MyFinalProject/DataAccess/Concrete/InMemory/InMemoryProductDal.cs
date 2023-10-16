using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>{
                new Product { ProductID = 1, CategoryID = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15 },
                new Product { ProductID = 2, CategoryID = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3 },
                new Product { ProductID = 3, CategoryID = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2 },
                new Product { ProductID = 4, CategoryID = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65 },
                new Product { ProductID = 5, CategoryID = 2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1 },
            };
        }

        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public IEnumerable<Product> Getproduct()
        {
            return _products;
        }

        public void Delete(Product entity)
        {
            Product productToDelete = _products.FirstOrDefault(p => p.ProductID == entity.ProductID);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _products.AsQueryable().FirstOrDefault(filter);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
        {
            if (filter != null)
            {
                return _products.AsQueryable().Where(filter).ToList();
            }
            return _products;
        }

        public List<Product> GetAllByCategory(int category)
        {
            return _products.Where(p => p.CategoryID == category).ToList();
        }

        public void Update(Product entity)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == entity.ProductID);
            if (productToUpdate != null)
            {
                productToUpdate.ProductName = entity.ProductName;
                productToUpdate.CategoryID = entity.CategoryID;
                productToUpdate.UnitPrice = entity.UnitPrice;
                productToUpdate.UnitsInStock = entity.UnitsInStock;
            }
        }
    }
}
