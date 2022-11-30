using EntityLayer.Concrete.UserVM;
using FluentValidation;
using System.Text.RegularExpressions;

namespace BusinessLayer.Validation.UserValidations
{
    public class UserPostDTOValidator : AbstractValidator<UserPostDTO>
    {
        public UserPostDTOValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("İsim kısmı boş veya null olamaz.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("İsim kısmı 50 karakterden fazla olamaz.");

            RuleFor(x => x.Surname).NotNull().NotEmpty().WithMessage("Soyisim kısmı boş veya null olamaz.");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Soyisim kısmı 30 karakterden fazla olamaz.");

            RuleFor(x => x.Username).NotNull().NotEmpty().WithMessage("Username kısmı boş veya null olamaz.");
            RuleFor(x => x.Username).MaximumLength(50).WithMessage("Username kısmı 50 karakterden fazla olamaz.");

            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Password kısmı boş veya null olamaz.");
            RuleFor(x => x.Password).MaximumLength(20).WithMessage("Password kısmı 20 karakterden fazla olamaz.");
            RuleFor(x => x.Password).Must(BeValidPassword).WithMessage("Password en az bir büyük karakter içermelidir.");

            RuleFor(x => x.PhoneNumber).NotNull().NotEmpty().WithMessage("Cep Telefon numarası kısmı boş veya null olamaz.");
            RuleFor(x => x.PhoneNumber).MaximumLength(20).WithMessage("Cep telefonu numarası kısmı en fazla 12 karakterden oluşabilir.");
            RuleFor(x => x.PhoneNumber).Must(BeValidPhoneNumber).WithMessage("Cep telefonu numarası geçersiz. Lütfen ülke kodu ile birlikte doğru ve eksiksiz giriniz.");

            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres kısmı boş olamaz.");
            RuleFor(x => x.Address).MaximumLength(200).WithMessage("Adres kısmı en fazla 200 karakterden oluşabilir.");



        }

        public bool BeValidPassword(string password)
        {
            bool checkForUpper = password.Any(char.IsUpper);

            var regx = new Regex("^(?=.*[a-z])(?=.*[A-Z]).*$");
            bool checkForSpecialChar = regx.IsMatch(password);

            return checkForUpper && checkForSpecialChar;
        }

        public bool BeValidPhoneNumber(string phoneNumber)
        {
            return (new Regex("^\\s*(?:\\+?(\\d{1,3}))?[-. (]*(\\d{3})[-. )]*(\\d{3})[-. ]*(\\d{4})(?: *x(\\d+))?\\s*$")).IsMatch(phoneNumber);
        }

    }
}
