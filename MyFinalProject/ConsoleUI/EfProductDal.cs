// See https://aka.ms/new-console-template for more information
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

internal class EfProductDal : IProductDal
{
    public void Add(Product entity)
    {
        /*NorthwindContext northwindContext = new NorthwindContext(); 
         Alttaki bunun benzer işlevi IDisposable pattern implementation of c#*/
        using (NorthwindContext context=new NorthwindContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();

        }
    }

    public void Delete(Product entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();

        }
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return context.Set<Product>().First(filter);
        }
    }

    public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
        }
    }

    public void Update(Product entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}