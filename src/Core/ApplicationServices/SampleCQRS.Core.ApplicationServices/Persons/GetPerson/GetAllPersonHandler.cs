using MediatR;
using SampleCQRS.Core.Domain.Contracts;

namespace SampleCQRS.Core.ApplicationServices.Persons.GetPerson;

public class GetAllPersonHandler : IRequestHandler<GetAllPersonQuery, GetAllPersonQueryResult>
{
    private readonly IPersonRepository repository;

    public GetAllPersonHandler(IPersonRepository repository)
    {
        this.repository = repository;
    }

    public Task<GetAllPersonQueryResult> Handle(GetAllPersonQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}