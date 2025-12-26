using CarRental.Entities.Concrete;
using CarRental.Entities.Dtos;

namespace CarRental.Business.Abstract
{
    public interface IRentalService
    {
        List<Rental> GetAll();
        Rental GetById(int id);
        void Add(Rental rental);
        void Update(Rental rental);
        void Delete(int id);
        List<VehicleRevenueDto> GetVehicleRevenue();
    }
}
