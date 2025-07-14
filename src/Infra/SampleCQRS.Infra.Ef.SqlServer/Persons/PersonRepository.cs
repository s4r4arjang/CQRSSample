using EndPoint.Api.Domain.Persons;
using SampleCQRS.Core.Domain.Contracts;

namespace EndPoint.Api.Infra.Persons
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonContext _personContext;

        public PersonRepository(PersonContext personContext)
        {
            this._personContext = personContext;
        }
        public void AddPerson(Person person)
        {
            _personContext.Add(person);
        }

        public async Task<int> SaveChange(CancellationToken cancellationToken = default)
        {
            return await _personContext.SaveChangesAsync(cancellationToken);
            
        }
    }
}
