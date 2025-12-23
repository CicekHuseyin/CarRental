using CarRental.Business.Abstract;
using CarRental.Business.Validation;
using CarRental.Entities.Dtos;

namespace CarRental.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly LoginValidator _validator = new();

        public bool Login(LoginDto dto)
        {
            try
            {
                var result = _validator.Validate(dto);

                if (!result.IsValid)
                    throw new Exception(result.Errors[0].ErrorMessage);

                // İş kuralı (gerçek kontrol)
                if (dto.Username != "admin" || dto.Password != "1234")
                    throw new Exception("Kullanıcı adı veya şifre hatalı");

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
