using EndPoint.Api.Domain.Persons;
using SampleCQRS.Core.Domain.Common;
using SampleCQRS.Core.Domain.Contracts;

namespace SampleCQRS.Core.ApplicationServices.Persons.CreatePerson;

public class CreatePersonHandler : ICommandHandler<CreatePersonCommand, CreatePersonResult>
{
    private readonly IPersonRepository personRepository;

    public CreatePersonHandler(IPersonRepository personRepository)
    {
        this.personRepository = personRepository;
    }
    public async Task<CreatePersonResult> Handle(CreatePersonCommand command)
    {
        var person = new Person()
        {
            Name = command.Name
        };

        personRepository.AddPerson(person);
       await personRepository.SaveChange();
        return new CreatePersonResult() { PersonId = person.Id };


    }
}
