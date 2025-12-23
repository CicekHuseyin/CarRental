using CarRental.Business.Abstract;
using CarRental.Business.Validation;
using CarRental.DataAccess.Concrete;
using CarRental.Entities.Concrete;

namespace CarRental.Business.Concrete
{
    public class VehicleManager : IVehicleService
    {
        private readonly VehicleRepository _repo;
        private readonly VehicleValidator _validator;

        public VehicleManager()
        {
            _repo = new VehicleRepository();
            _validator = new VehicleValidator();
        }

        /// <summary>
        /// Yeni bir aracı sisteme ekler.
        /// Araç bilgileri FluentValidation ile doğrulanır.
        /// </summary>
        /// <param name="vehicle">Eklenecek araç bilgileri</param>
        public void Add(Vehicle vehicle)
        {
            try
            {
                if (vehicle == null)
                    throw new Exception("Araç bilgisi boş olamaz");

                // Varsayılan olarak araç müsait kabul edilir
                vehicle.IsAvailable = true;

                var result = _validator.Validate(vehicle);
                if (!result.IsValid)
                    throw new Exception(result.Errors.First().ErrorMessage);

                _repo.Add(vehicle);
            }
            catch (Exception ex)
            {
                throw new Exception("Araç ekleme işlemi başarısız.", ex);
            }
        }

        /// <summary>
        /// Belirtilen Id değerine sahip aracı sistemden siler.
        /// </summary>
        public void Delete(int id)
        {
            try
            {
                if (id <= 0)
                    throw new Exception("Geçersiz araç ID");

                _repo.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Araç silme işlemi başarısız.", ex);
            }
        }

        /// <summary>
        /// Sistemde kayıtlı tüm araçları listeler.
        /// </summary>
        public List<Vehicle> GetAll()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Araç listesi getirilirken hata oluştu.", ex);
            }
        }

        /// <summary>
        /// Belirtilen Id değerine sahip aracı getirir.
        /// </summary>
        public Vehicle GetById(int id)
        {
            try
            {
                if (id <= 0)
                    throw new Exception("Geçersiz araç ID");

                return _repo.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Araç bilgisi getirilirken hata oluştu.", ex);
            }
        }

        /// <summary>
        /// Mevcut bir aracın bilgilerini günceller.
        /// </summary>
        public void Update(Vehicle vehicle)
        {
            try
            {
                if (vehicle == null)
                    throw new Exception("Araç bilgisi boş olamaz");

                if (vehicle.Id <= 0)
                    throw new Exception("Geçersiz araç ID");

                var result = _validator.Validate(vehicle);
                if (!result.IsValid)
                    throw new Exception(result.Errors.First().ErrorMessage);

                _repo.Update(vehicle);
            }
            catch (Exception ex)
            {
                throw new Exception("Araç güncelleme işlemi başarısız.", ex);
            }
        }
    }
}
