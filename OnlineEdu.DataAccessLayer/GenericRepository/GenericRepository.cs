using Microsoft.EntityFrameworkCore;
using OnlineEdu.DataAccessLayer.Abstract;
using OnlineEdu.DataAccessLayer.Concrete;
using System.Linq.Expressions;

namespace OnlineEdu.DataAccessLayer.GenericRepository
{
    public class GenericRepository<Entity>(AppDbContext _dbContext) : IGenericRepository<Entity> where Entity : class
    {
        public DbSet<Entity> Table { get => _dbContext.Set<Entity>(); }
        public void Add(Entity entity)
        {
            Table.Add(entity);
            _dbContext.SaveChanges();
        }

        public int Count()
        {
            return Table.Count();
        }

        public void Delete(int id)
        {
            var entity = Table.Find(id);
            Table.Remove(entity);
            _dbContext.SaveChanges();
        }

        public int FilteredCount(Expression<Func<Entity, bool>> predicate)
        {
            return Table.Where(predicate).Count();
        }

        public Entity GetByFilter(Expression<Func<Entity, bool>> predicate)
        {
            return Table.Where(predicate).FirstOrDefault();
        }

        public Entity GetById(int Id)
        {
            return Table.Find(Id);

        }

        public List<Entity> GetFilteredList(Expression<Func<Entity, bool>> predicate)
        {
            return Table.Where(predicate).ToList();
        }

        public List<Entity> GetListAll()
        {
            return Table.ToList();
        }

        public void Update(Entity entity)
        {
            Table.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
