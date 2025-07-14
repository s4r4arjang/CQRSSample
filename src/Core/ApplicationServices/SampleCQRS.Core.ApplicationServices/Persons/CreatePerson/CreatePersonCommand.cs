using SampleCQRS.Core.Domain.Common;

namespace SampleCQRS.Core.ApplicationServices.Persons.CreatePerson
{
    public class CreatePersonCommand : ICommand 
    {
        public string Name { get; set; }
    }
}