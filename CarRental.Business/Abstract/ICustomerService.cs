using CarRental.Entities.Concrete;

namespace CarRental.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
    }
}
