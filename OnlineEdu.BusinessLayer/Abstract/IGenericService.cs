using System.Linq.Expressions;

namespace OnlineEdu.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T:class
    {
        List<T> TGetListAll();
        T TGetByFilter(Expression<Func<T, bool>> predicate);
        void TAdd(T t);
        void TDelete(int id);
        T TGetById(int Id);
        void TUpdate(T t);
        int TCount();
        int TFilteredCount(Expression<Func<T, bool>> predicate);
        List<T> TGetFilteredList(Expression<Func<T, bool>> predicate);
    }
}
