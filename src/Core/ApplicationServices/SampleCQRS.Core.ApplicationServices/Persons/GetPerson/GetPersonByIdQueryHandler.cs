using MediatR;
using SampleCQRS.Core.Domain.Contracts;

namespace SampleCQRS.Core.ApplicationServices.Persons.GetPerson
{
    public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, GetPersonByIdQueryResult>
    {
        private readonly IPersonRepository personRepository;

        public GetPersonByIdQueryHandler(IPersonRepository personRepository )
        {
            this.personRepository = personRepository;
        }
        public  async Task<GetPersonByIdQueryResult> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            //  var res=  personRepository.GetPerson(request.PersonId);
            //   var res1 = new GetPersonByIdQueryResult
            //   {
            //       Name= res.Name
            //   };
            //return await Task.FromResult(res1);
            var res = await personRepository.GetPersonAsync(request.PersonId);
            return new GetPersonByIdQueryResult
            {
                Name = res.Name
            };

        }
    }
}