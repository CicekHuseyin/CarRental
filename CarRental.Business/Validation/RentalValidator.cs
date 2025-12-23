using CarRental.Entities.Concrete;
using FluentValidation;

namespace CarRental.Business.Validation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(x => x.VehicleId)
                .GreaterThan(0)
                .WithMessage("Araç seçilmelidir");

            RuleFor(x => x.CustomerId)
                .GreaterThan(0)
                .WithMessage("Müşteri seçilmelidir");

            RuleFor(x => x.RentDate)
                .NotEmpty()
                .WithMessage("Kiralama tarihi boş olamaz")
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("Kiralama tarihi bugünden ileri olamaz");

            RuleFor(x => x.TotalPrice)
                .GreaterThan(0)
                .WithMessage("Toplam fiyat 0'dan büyük olmalıdır");

            RuleFor(x => x.ReturnDate)
                .GreaterThan(x => x.RentDate)
                .When(x => x.ReturnDate.HasValue)
                .WithMessage("Teslim tarihi kiralama tarihinden önce olamaz");
        }
    }
}
