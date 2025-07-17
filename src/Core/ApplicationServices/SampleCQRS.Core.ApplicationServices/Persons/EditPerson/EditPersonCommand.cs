using MediatR;

namespace SampleCQRS.Core.ApplicationServices.Persons.EditPerson
{
    public class EditPersonCommand : IRequest<EditPersonResult>
    {
    }
}