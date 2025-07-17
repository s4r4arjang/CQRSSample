using EndPoint.Api.Domain.Persons;

namespace SampleCQRS.Core.Domain.Contracts;

public interface IPersonRepository
{
    void AddPerson(Person person);
    Task<int> SaveChange(CancellationToken cancellationToken=default);
    Person GetPerson(int Id);
   Task<Person>  GetPersonAsync(int Id);

}
