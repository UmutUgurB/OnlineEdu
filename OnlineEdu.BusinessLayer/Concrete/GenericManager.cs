using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DataAccessLayer.Abstract;
using System.Linq.Expressions;

namespace OnlineEdu.BusinessLayer.Concrete                  
{
    public class GenericManager<T>(IGenericRepository<T> _genericRepository) : IGenericService<T> where T : class
    {
        public void TAdd(T t)
        {
            _genericRepository.Add(t);
        }

        public int TCount()
        {
            return _genericRepository.Count();
        }

        public void TDelete(int id)
        {
            _genericRepository.Delete(id);
        }

        public int TFilteredCount(Expression<Func<T, bool>> predicate)
        {
            return _genericRepository.FilteredCount(predicate);
        }

        public T TGetByFilter(Expression<Func<T, bool>> predicate)
        {
            return _genericRepository.GetByFilter(predicate);
        }

        public T TGetById(int Id)
        {
            return _genericRepository.GetById(Id);
        }

        public List<T> TGetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return _genericRepository.GetFilteredList(predicate);
        }

        public List<T> TGetListAll()
        {
            return _genericRepository.GetListAll();
        }

        public void TUpdate(T t)
        {
            _genericRepository.Update(t);
        }
    }
}
