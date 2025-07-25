using EndPoint.Api.Domain.Persons;
using FluentValidation;
using MediatR;
using SampleCQRS.Core.Domain.Common;
using SampleCQRS.Core.Domain.Contracts;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SampleCQRS.Core.ApplicationServices.Persons.CreatePerson;
public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, CreatePersonResult>
{
    private readonly IPersonRepository personRepository;


    public CreatePersonHandler(IPersonRepository personRepository)
    {
        this.personRepository = personRepository;
   
    }
    public async Task<CreatePersonResult> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        // اعتبارسنجی
 
        var person = new Person()
        {
            Name = request.Name
        };

        personRepository.AddPerson(person);
        await personRepository.SaveChange();

        return new CreatePersonResult() { PersonId = person.Id };
    }


}
