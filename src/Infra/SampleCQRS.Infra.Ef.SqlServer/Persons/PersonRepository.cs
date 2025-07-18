﻿using EndPoint.Api.Domain.Persons;
using Microsoft.EntityFrameworkCore;
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

        public Person GetPerson(int Id)
        {
            return _personContext.Persons.Where(p=>p.Id == Id).FirstOrDefault(); 
        }

        public async Task<Person> GetPersonAsync(int Id)
        {
            return await _personContext.Persons.SingleOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<int> SaveChange(CancellationToken cancellationToken = default)
        {
            return await _personContext.SaveChangesAsync(cancellationToken);
            
        }
    }
}
