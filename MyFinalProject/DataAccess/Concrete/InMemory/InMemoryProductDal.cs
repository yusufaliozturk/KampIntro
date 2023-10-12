using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        readonly List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>{
                
                new Product{ProductID=1, CategoryID=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductID=2, CategoryID=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductID=3, CategoryID=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductID=4, CategoryID=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductID=5, CategoryID=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1},

            };
        }

        public List<Product> GetAllByCategory(int category)
        {
            throw new NotImplementedException();
        }

        void IProductDal.Add(Product product)
        {
            _products.Add(product);
        }

        void IProductDal.Delete(Product product)
        {
            //LINQ -Language Integrated Query
            //Lambda
            Product productToDelete = _products.First(p => p.ProductID == product.ProductID);
            _products.Remove(productToDelete);

        }

        List<Product> IProductDal.GetAll()
        {
            return _products;

        }

        void IProductDal.Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.First(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;  
            productToUpdate.UnitsInStock = product.UnitsInStock;   
        }
    }
}
