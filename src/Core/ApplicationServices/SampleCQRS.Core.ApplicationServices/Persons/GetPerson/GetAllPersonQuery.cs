using MediatR;
using SampleCQRS.Core.ApplicationServices.Persons.EditPerson;

namespace SampleCQRS.Core.ApplicationServices.Persons.GetPerson;

public class GetAllPersonQuery : IRequest<GetAllPersonQueryResult>
{
}
