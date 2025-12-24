using CarRental.Entities.Concrete;
using FluentValidation;

namespace CarRental.Business.Validation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FullName)
            .NotEmpty().WithMessage("Müşteri adı boş olamaz")
            .MinimumLength(3).WithMessage("Müşteri adı en az 3 karakter olmalıdır");

            RuleFor(x => x.Phone)
                .NotEmpty().
                WithMessage("Telefon numarası boş olamaz");

            RuleFor(x => x.TC)
                .NotEmpty().WithMessage("TC Kimlik No boş olamaz")
                .Length(11).WithMessage("TC Kimlik No 11 haneli olmalıdır")
                .Must(BeValidTc)
                .WithMessage("TC Kimlik No geçersiz");
        }

        /// <summary>
        /// TC Kimlik No doğrulama algoritması
        /// </summary>
        private bool BeValidTc(string tc)
        {
            if (string.IsNullOrWhiteSpace(tc) || tc.Length != 11)
                return false;

            return tc.All(char.IsDigit) && tc[0] != '0';
        }
    }
}
