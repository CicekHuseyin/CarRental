using CarRental.Business.Abstract;
using CarRental.Business.Validation;
using CarRental.DataAccess.Concrete;
using CarRental.Entities.Concrete;

namespace CarRental.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly CustomerRepository _repo;
        private readonly CustomerValidator _validator;

        public CustomerManager()
        {
            _repo = new CustomerRepository();
            _validator = new CustomerValidator();
        }

        /// <summary>
        /// Yeni bir müşteri kaydını sisteme ekler.
        /// İş kuralı kontrolleri bu metot içerisinde yapılır.
        /// </summary>
        /// <param name="customer">Eklenecek müşteri bilgileri</param>
        /// <exception cref="Exception">
        /// Müşteri bilgileri geçersiz olduğunda veya ekleme sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public void Add(Customer customer)
        {
            try
            {
                var result = _validator.Validate(customer);

                if (!result.IsValid)
                    throw new Exception(result.Errors.First().ErrorMessage);

                _repo.Add(customer);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri ekleme işlemi başarısız.", ex);
            }
        }

        /// <summary>
        /// Belirtilen Id değerine sahip müşteriyi sistemden siler.
        /// </summary>
        /// <param name="id">Silinecek müşteri Id değeri</param>
        /// <exception cref="Exception">
        /// Id geçersiz olduğunda veya silme sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public void Delete(int id)
        {
            if (id <= 0)
                throw new Exception("Geçersiz müşteri ID");

            _repo.Delete(id);
        }

        /// <summary>
        /// Sistemde kayıtlı tüm müşterileri listeler.
        /// </summary>
        /// <returns>Müşteri listesi</returns>
        /// <exception cref="Exception">
        /// Listeleme sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public List<Customer> GetAll()
        {
            try
            {
                return _repo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri listesi getirilirken hata oluştu.", ex);
            }
        }

        /// <summary>
        /// Belirtilen Id değerine sahip müşteri bilgisini getirir.
        /// </summary>
        /// <param name="id">Müşteri Id değeri</param>
        /// <returns>
        /// Müşteri bulunursa Customer nesnesi, bulunamazsa null.
        /// </returns>
        /// <exception cref="Exception">
        /// Id geçersiz olduğunda veya getirme sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public Customer GetById(int id)
        {
            if (id <= 0)
                throw new Exception("Geçersiz müşteri ID");

            return _repo.GetById(id);
        }

        /// <summary>
        /// Mevcut bir müşterinin bilgilerini günceller.
        /// </summary>
        /// <param name="customer">Güncellenecek müşteri bilgileri</param>
        /// <exception cref="Exception">
        /// Bilgiler geçersiz olduğunda veya güncelleme sırasında hata oluştuğunda fırlatılır.
        /// </exception>
        public void Update(Customer customer)
        {
            try
            {
                if (customer.Id <= 0)
                    throw new Exception("Geçersiz müşteri ID");

                var result = _validator.Validate(customer);

                if (!result.IsValid)
                    throw new Exception(result.Errors.First().ErrorMessage);

                _repo.Update(customer);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri güncelleme işlemi başarısız.", ex);
            }
        }
    }

}
