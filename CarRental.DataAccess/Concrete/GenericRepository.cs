using CarRental.DataAccess.Abstract;
using CarRental.DataAccess.Db;
using CarRental.Entities.Concrete;
using Microsoft.Data.SqlClient;

namespace CarRental.DataAccess.Concrete
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity, new()
    {
        protected SqlConnection connection;

        public GenericRepository()
        {
            connection = SqlConnectionFactory.GetConnection();
        }

        public abstract List<T> GetAll();
        public abstract T GetById(int id);
        public abstract void Add(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(int id);
    }
}
