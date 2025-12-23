using CarRental.Business.Abstract;
using CarRental.Business.Validation;
using CarRental.DataAccess.Concrete;
using CarRental.Entities.Concrete;

namespace CarRental.Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly RentalRepository _repo;
        private readonly RentalValidator _validator;

        public RentalManager()
        {
            _repo = new RentalRepository();
            _validator = new RentalValidator();
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

                // Default tarih ataması (business kararı)
                if (rental.RentDate == default)
                    rental.RentDate = DateTime.Now;

                var result = _validator.Validate(rental);
                if (!result.IsValid)
                    throw new Exception(result.Errors.First().ErrorMessage);

                _repo.Add(rental);
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
        public List<Rental> GetAll()
        {
            try
            {
                return _repo.GetAll();
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
    }
}
