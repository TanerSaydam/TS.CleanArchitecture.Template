using FluentValidation;

namespace CleanArchitecture.Application.Features.Auth.Login;
public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(p => p.EmailOrUserName)
            .MinimumLength(3)
            .WithMessage("Kullanıcı adı ya da mail bilgisi en az 3 karakter olmalıdır");
        RuleFor(p => p.Password)
            .MinimumLength(1)
            .WithMessage("Şifre en az 1 karakter olmalıdır");
    }
}
