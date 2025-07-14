namespace SampleCQRS.Core.ApplicationServices.Persons.EditPerson;

public class EditPersonHandler : ICommandHandler<EditPersonCommand, EditPersonResult>
{
    public Task<EditPersonResult> Handle(EditPersonCommand command)
    {
        throw new NotImplementedException();
    }
}
