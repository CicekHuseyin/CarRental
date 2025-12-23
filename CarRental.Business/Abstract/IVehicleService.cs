using CarRental.Entities.Concrete;

namespace CarRental.Business.Abstract
{
    public interface IVehicleService
    {
        List<Vehicle> GetAll();
        Vehicle GetById(int id);
        void Add(Vehicle vehicle);
        void Update(Vehicle vehicle);
        void Delete(int id);
    }
}
