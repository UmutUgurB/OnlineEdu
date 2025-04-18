using System.Linq.Expressions;

namespace OnlineEdu.DataAccessLayer.Abstract
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        List<Entity> GetListAll();
        Entity GetByFilter(Expression<Func<Entity,bool>>predicate);
        void Add(Entity entity);
        void Delete(int id);
        Entity GetById(int Id);
        void Update(Entity entity);
        int Count();
        int FilteredCount(Expression<Func<Entity, bool>> predicate);
        List<Entity> GetFilteredList(Expression<Func<Entity,bool>> predicate);
    }
}
