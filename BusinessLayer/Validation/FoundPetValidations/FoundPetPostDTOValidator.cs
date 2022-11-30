using EntityLayer.Concrete.FoundPetVM;
using FluentValidation;

namespace BusinessLayer.Validation.FoundPetValidations
{
    public class FoundPetPostDTOValidator : AbstractValidator<FoundPetPostPutDTO>
    {
        public FoundPetPostDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim kısmı boş olamaz.");
            RuleFor(x => x.Name).MaximumLength(25).WithMessage("İsim kısmı 25 karakterden fazla olamaz.");

            RuleFor(x => x.Breed).NotEmpty().WithMessage("Soy kısmı boş olamaz.");
            RuleFor(x => x.Breed).MaximumLength(50).WithMessage("Soy kısmı 50 karakterden fazla olamaz.");

            RuleFor(x => x.Species).NotEmpty().WithMessage("Tür kısmı boş olamaz.");
            RuleFor(x => x.Species).MaximumLength(25).WithMessage("Tür kısmı 25 karakterden fazla olamaz.");

            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş kısmı boş olamaz.");
            RuleFor(x => x.Age).InclusiveBetween(0, 30).WithMessage("Yaş kısmı 0 ile 30 arasında değer alabilir.");

            RuleFor(x => x.Health).NotNull().NotEmpty().WithMessage("Sağlık durumu kısmı boş veya null olamaz.");
            RuleFor(x => x.Health).MaximumLength(50).WithMessage("Sağlık kısmı 50 karakterden fazla olamaz.");

            RuleFor(x => x.IsMissing).NotNull().NotEmpty().WithMessage("Kayıp durumu kısmı boş veya null olamaz.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş olamaz.");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Açıklama kısmı 200 karakterden fazla olamaz.");

            RuleFor(x => x.UserId).NotNull().NotEmpty().WithMessage("UserID kısmı boş veya null olamaz.");
            RuleFor(x => x.UserId).GreaterThan(0).WithMessage("UsedID 0'dan büyük olmalıdır.");

            RuleFor(x => x.FindingDate).NotNull().NotEmpty().WithMessage("Kayıp olma tarihi kısmı boş veya null olamaz.");
            RuleFor(x => x.FindingDate).Must(BeValidFoundDate).WithMessage("Kayıp olma tarihi gelecekte olamaz.");

            RuleFor(x => x.FoundAddress).NotEmpty().WithMessage("En son görülme kısmı boş olamaz. Hatırlamıyorsanız lütfen null geçin.");
            RuleFor(x => x.FoundAddress).MaximumLength(300).WithMessage("En son görülme kısmı 300 karakterden fazla olamaz.");

        }
        public bool BeValidFoundDate(DateTime missingDate)
        {
            return missingDate >= DateTime.MinValue && missingDate <= DateTime.MaxValue && missingDate <= DateTime.Now;
        }
    }
}
