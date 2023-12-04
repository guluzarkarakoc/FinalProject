using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryDal
{
    public class InMemoryProductDal:IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=2},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=3},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=15, UnitsInStock=1}
            };
        }
        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public void Delete(Product entity)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> Get(Expression<Func<Product, bool>> filter)
        {
            return _products;

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public List<Product> GetById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailsDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailsDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock };

                return result.ToList();

            }
        }

        public void Update(Product entity)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            productToUpdate.ProductName = entity.ProductName;
            productToUpdate.CategoryId = entity.CategoryId;
            productToUpdate.UnitPrice = entity.UnitPrice;
            productToUpdate.UnitsInStock = entity.UnitsInStock;
        }

        Product IEntityRepository<Product>.Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
