namespace SampleCQRS.Core.ApplicationServices.Persons.CreatePerson;


using FluentValidation;

public class CreatePersonValidator : AbstractValidator<CreatePersonCommand>
{
    public CreatePersonValidator()
    {
        RuleFor(x => x.Name)
.NotEmpty().WithMessage("نام الزامی است")
.MinimumLength(3).WithMessage("نام باید حداقل ۳ حرف باشد");
    }
}
