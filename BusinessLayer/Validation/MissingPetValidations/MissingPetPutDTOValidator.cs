using EntityLayer.Concrete.MissingPetVM;
using FluentValidation;

namespace BusinessLayer.Validation.MissingPetValidations
{
    public class MissingPetPutDTOValidator : AbstractValidator<MissingPetPostPutDTO>
    {
        public MissingPetPutDTOValidator()
        {
            RuleFor(x => x.Name).MaximumLength(25).WithMessage("İsim kısmı 25 karakterden fazla olamaz.");

            RuleFor(x => x.Breed).MaximumLength(50).WithMessage("Soy kısmı 50 karakterden fazla olamaz.");

            RuleFor(x => x.Species).MaximumLength(25).WithMessage("Tür kısmı 25 karakterden fazla olamaz.");

            RuleFor(x => x.Age).InclusiveBetween(0, 30).WithMessage("Yaş kısmı 0 ile 30 arasında değer alabilir.");

            RuleFor(x => x.Health).MaximumLength(50).WithMessage("Sağlık kısmı 50 karakterden fazla olamaz.");

            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Açıklama kısmı 200 karakterden fazla olamaz.");

            RuleFor(x => x.UserId).GreaterThan(0).WithMessage("UsedID 0'dan büyük olmalıdır.");

            RuleFor(x => x.MissingDate).Must(BeValidMissingDate).WithMessage("Kayıp olma tarihi gelecekte olamaz.");

            RuleFor(x => x.LastSeenAddress).MaximumLength(300).WithMessage("En son görülme kısmı 300 karakterden fazla olamaz.");

        }

        public bool BeValidMissingDate(DateTime missingDate)
        {
            return missingDate >= DateTime.MinValue && missingDate <= DateTime.MaxValue && missingDate <= DateTime.Now;
        }
    }
}
