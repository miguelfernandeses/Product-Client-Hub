using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Clients.SharedValidator
{
    public class RequestClientValidator : AbstractValidator<RequestClientJson>
    {
        public RequestClientValidator()
        {
            RuleFor(client => client.Name).NotEmpty().WithMessage("Nome não pode ser vazio.");
            RuleFor(client => client.Email).EmailAddress().WithMessage("O e-mail não é válido.");
        }
    }
}
