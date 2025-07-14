using EndPoint.Api.Domain.Persons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Common;

namespace EndPoint.Api.Infra.Persons
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
       : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
    }
}
