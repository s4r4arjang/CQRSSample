using MediatR;
using SampleCQRS.Core.ApplicationServices.Persons.CreatePerson;

namespace SampleCQRS.Core.ApplicationServices.Persons.EditPerson;

public class EditPersonHandler : IRequestHandler<EditPersonCommand, EditPersonResult>
{
    public Task<EditPersonResult> Handle(EditPersonCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}



