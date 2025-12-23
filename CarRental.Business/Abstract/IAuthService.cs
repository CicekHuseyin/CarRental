using CarRental.Entities.Dtos;

namespace CarRental.Business.Abstract
{
    public interface IAuthService
    {
        public bool Login(LoginDto dto);
    }
}
