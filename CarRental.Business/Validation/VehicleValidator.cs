using CarRental.Entities.Concrete;
using FluentValidation;

namespace CarRental.Business.Validation
{
    public class VehicleValidator : AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(x => x.Plate)
                .NotEmpty().WithMessage("Plaka boş olamaz")
                .MinimumLength(5).WithMessage("Plaka en az 5 karakter olmalıdır");

            RuleFor(x => x.Brand)
                .NotEmpty().WithMessage("Marka boş olamaz");

            RuleFor(x => x.Model)
                .NotEmpty().WithMessage("Model boş olamaz");

            RuleFor(x => x.ProductionYear)
                .GreaterThanOrEqualTo(1990).WithMessage("Üretim yılı 1990'dan küçük olamaz")
                .LessThanOrEqualTo(DateTime.Now.Year).WithMessage("Üretim yılı gelecek bir yıl olamaz");

            RuleFor(x => x.Kilometer)
                .GreaterThanOrEqualTo(0).WithMessage("Kilometre negatif olamaz");

            RuleFor(x => x.Color)
                .NotEmpty().WithMessage("Renk bilgisi boş olamaz");

            RuleFor(x => x.DailyPrice)
                .GreaterThan(0).WithMessage("Günlük fiyat 0'dan büyük olmalıdır");
        }
    }
}
