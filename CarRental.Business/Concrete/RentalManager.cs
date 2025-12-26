using CarRental.Business.Abstract;
using CarRental.Business.Validation;
using CarRental.DataAccess.Concrete;
using CarRental.Entities.Concrete;
using CarRental.Entities.Dtos;

namespace CarRental.Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly RentalRepository _repo;
        private readonly RentalValidator _validator;
        private readonly VehicleRepository _vehicleRepo;
        private readonly CustomerRepository _customerRepo;

        public RentalManager()
        {
            _repo = new RentalRepository();
            _validator = new RentalValidator();
            _vehicleRepo = new VehicleRepository();
            _customerRepo = new CustomerRepository();
        }

        /// <summary>
        /// Yeni bir araç kiralama işlemini sisteme ekler.
        /// İş kuralları FluentValidation ile kontrol edilir.
        /// </summary>
        /// <param name="rental">Eklenecek kiralama bilgileri</param>
        /// <exception cref="Exception">
        /// Kiralama bilgileri geçersiz olduğunda veya ekleme sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public void Add(Rental rental)
        {
            try
            {
                if (rental == null)
                    throw new Exception("Kiralama bilgisi boş olamaz");

                if (!rental.ReturnDate.HasValue)
                    throw new Exception("Teslim tarihi boş olamaz");

                if (rental.RentDate > rental.ReturnDate)
                    throw new Exception("Teslim tarihi kiralama tarihinden küçük olamaz");

                // Araç bilgisi çekilir
                var vehicle = _vehicleRepo.GetById(rental.VehicleId);
                if (vehicle == null)
                    throw new Exception("Araç bulunamadı");

                // Gün sayısı hesaplanır
                int totalDays = (rental.ReturnDate.Value.Date - rental.RentDate.Date).Days;
                if (totalDays <= 0)
                    totalDays = 1;

                // TOPLAM FİYAT HESABI
                rental.TotalPrice = totalDays * vehicle.DailyPrice;

                var result = _validator.Validate(rental);
                if (!result.IsValid)
                    throw new Exception(result.Errors.First().ErrorMessage);

                _repo.Add(rental);

                // Araç pasif hale getirilir
                vehicle.IsAvailable = false;
                _vehicleRepo.Update(vehicle);
            }
            catch (Exception ex)
            {
                throw new Exception("Kiralama ekleme işlemi başarısız.", ex);
            }
        }

        /// <summary>
        /// Belirtilen Id değerine sahip kiralama kaydını sistemden siler.
        /// </summary>
        public void Delete(int id)
        {
            try
            {
                if (id <= 0)
                    throw new Exception("Geçersiz kiralama ID");

                _repo.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Kiralama silme işlemi başarısız.", ex);
            }
        }

        /// <summary>
        /// Sistemde kayıtlı tüm kiralama işlemlerini listeler.
        /// </summary>
        public List<RentalListDto> GetAll()
        {
            try
            {
                var rentals = _repo.GetAll();
                var vehicles = _vehicleRepo.GetAll();
                var customers = _customerRepo.GetAll();

                var list = rentals.Select(r => new RentalListDto
                {
                    Id = r.Id,
                    Plate = vehicles.First(v => v.Id == r.VehicleId).Plate,
                    CustomerFullName = customers.First(c => c.Id == r.CustomerId).FullName,
                    RentDate = r.RentDate,
                    ReturnDate = r.ReturnDate,
                    TotalPrice = r.TotalPrice
                }).ToList();

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Kiralama listesi getirilirken hata oluştu.", ex);
            }
        }

        /// <summary>
        /// Belirtilen Id değerine sahip kiralama bilgisini getirir.
        /// </summary>
        public Rental GetById(int id)
        {
            try
            {
                if (id <= 0)
                    throw new Exception("Geçersiz kiralama ID");

                return _repo.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Kiralama bilgisi getirilirken hata oluştu.", ex);
            }
        }

        /// <summary>
        /// Mevcut bir kiralama kaydının bilgilerini günceller.
        /// </summary>
        public void Update(Rental rental)
        {
            try
            {
                if (rental == null)
                    throw new Exception("Kiralama bilgisi boş olamaz");

                if (rental.Id <= 0)
                    throw new Exception("Geçersiz kiralama ID");

                if (!rental.ReturnDate.HasValue)
                    throw new Exception("Teslim tarihi boş olamaz");

                if (rental.RentDate > rental.ReturnDate)
                    throw new Exception("Teslim tarihi kiralama tarihinden küçük olamaz");

                // Araç bilgisi çekilir
                var vehicle = _vehicleRepo.GetById(rental.VehicleId);
                if (vehicle == null)
                    throw new Exception("Araç bulunamadı");

                // Gün sayısı hesaplanır
                int totalDays =
                    (rental.ReturnDate.Value.Date - rental.RentDate.Date).Days;

                if (totalDays <= 0)
                    totalDays = 1;

                // TOPLAM FİYAT YENİDEN HESAPLANIR
                rental.TotalPrice = totalDays * vehicle.DailyPrice;

                var result = _validator.Validate(rental);
                if (!result.IsValid)
                    throw new Exception(result.Errors.First().ErrorMessage);

                _repo.Update(rental);
            }
            catch (Exception ex)
            {
                throw new Exception("Kiralama güncelleme işlemi başarısız.", ex);
            }
        }

        List<Rental> IRentalService.GetAll()
        {
            throw new NotImplementedException();
        }

        public List<VehicleRevenueDto> GetVehicleRevenue()
        {
            try
            {
                return _repo.GetVehicleRevenue();
            }
            catch (Exception ex)
            {
                throw new Exception("Araç bazlı ciro raporu alınamadı.", ex);
            }
        }

    }
}
