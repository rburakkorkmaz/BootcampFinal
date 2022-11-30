using EntityLayer.Concrete.FoundPetVM;
using FluentValidation;

namespace BusinessLayer.Validation.FoundPetValidations
{
    public class FoundPetPutDTOValidator : AbstractValidator<FoundPetPostPutDTO>
    {
        public FoundPetPutDTOValidator()
        {
            RuleFor(x => x.Name).MaximumLength(25).WithMessage("İsim kısmı 25 karakterden fazla olamaz.");

            RuleFor(x => x.Breed).MaximumLength(50).WithMessage("Soy kısmı 50 karakterden fazla olamaz.");

            RuleFor(x => x.Species).MaximumLength(25).WithMessage("Tür kısmı 25 karakterden fazla olamaz.");

            RuleFor(x => x.Age).InclusiveBetween(0, 30).WithMessage("Yaş kısmı 0 ile 30 arasında değer alabilir.");

            RuleFor(x => x.Health).MaximumLength(50).WithMessage("Sağlık kısmı 50 karakterden fazla olamaz.");

            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Açıklama kısmı 200 karakterden fazla olamaz.");

            RuleFor(x => x.FindingDate).Must(BeValidFoundDate).WithMessage("Kayıp olma tarihi gelecekte olamaz.");

            //RuleFor(x => x.FoundAddress).MinimumLength(1).WithMessage("En son görülme kısmı boş olamaz. Hatırlamıyorsanız lütfen null geçin.");
            RuleFor(x => x.FoundAddress).MinimumLength(1).MaximumLength(300).WithMessage("En son görülme kısmı 300 karakterden fazla olamaz.");

        }
        public bool BeValidFoundDate(DateTime missingDate)
        {
            return missingDate >= DateTime.MinValue && missingDate <= DateTime.MaxValue && missingDate <= DateTime.Now;
        }
    }
}
