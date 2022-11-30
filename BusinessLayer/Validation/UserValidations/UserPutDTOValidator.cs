using EntityLayer.Concrete.UserVM;
using FluentValidation;
using System.Text.RegularExpressions;

namespace BusinessLayer.Validation.UserValidations
{
    public class UserPutDTOValidator : AbstractValidator<UserPutDTO>
    {
        public UserPutDTOValidator()
        {
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("İsim kısmı 150 karakterden fazla olamaz.");

            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Soyisim kısmı 75 karakterden fazla olamaz.");

            RuleFor(x => x.PhoneNumber).Must(BeValidPhoneNumber).Unless(x => string.IsNullOrEmpty(x.PhoneNumber)).WithMessage("Cep telefonu numarası geçersiz. Lütfen ülke kodu ile birlikte doğru ve eksiksiz giriniz.");

            RuleFor(x => x.Address).MaximumLength(200).WithMessage("Adres kısmı en fazla 200 karakterden oluşabilir.");
        }

        public bool BeValidPhoneNumber(string phoneNumber)
        {
            return (new Regex("^\\s*(?:\\+?(\\d{1,3}))?[-. (]*(\\d{3})[-. )]*(\\d{3})[-. ]*(\\d{4})(?: *x(\\d+))?\\s*$")).IsMatch(phoneNumber);
        }
    }
}
