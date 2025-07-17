using MediatR;

namespace SampleCQRS.Core.ApplicationServices.Persons.GetPerson
{
    public class GetPersonByIdQuery : IRequest<GetPersonByIdQueryResult>
    {
        public int PersonId { get;  set; }
    }
}