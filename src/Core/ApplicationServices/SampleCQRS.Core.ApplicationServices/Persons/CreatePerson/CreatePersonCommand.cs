using MediatR;
using SampleCQRS.Core.Domain.Common;

namespace SampleCQRS.Core.ApplicationServices.Persons.CreatePerson;

public class CreatePersonCommand : IRequest<CreatePersonResult>
{
    public string Name { get; set; }
}
