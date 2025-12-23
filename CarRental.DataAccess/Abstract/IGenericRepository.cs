using CarRental.Entities.Concrete;

namespace CarRental.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
