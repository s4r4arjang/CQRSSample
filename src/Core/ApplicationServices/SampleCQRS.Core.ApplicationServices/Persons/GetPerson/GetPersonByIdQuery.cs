namespace SampleCQRS.Core.ApplicationServices.Persons.GetPerson
{
    public class GetPersonByIdQuery : ICommand
    {
        public int PersonId { get;  set; }
    }
}