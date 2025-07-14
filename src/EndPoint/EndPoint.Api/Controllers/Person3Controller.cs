
using Microsoft.AspNetCore.Mvc;
using SampleCQRS.Core.ApplicationServices.Persons.CreatePerson;
using SampleCQRS.Core.ApplicationServices.Persons.DeletePerson;
using SampleCQRS.Core.ApplicationServices.Persons.EditPerson;
using SampleCQRS.Core.ApplicationServices.Persons.GetPerson;
using SampleCQRS.Core.Domain.Common;

namespace EndPoint.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Person3Controller : ControllerBase
{
   // private readonly ICommandHandler<CreatePersonCommand, CreatePersonResult> createHandler;
    private readonly ICommandHandler<GetPersonByIdQuery, GetPersonByIdQueryResult> getByIdHandler;

    public Person3Controller(
    //ICommandHandler<EditPersonCommand, EditPersonResult> EditHandler ,
    //ICommandHandler<GetAllPersonQuery, GetAllPersonQueryResult> GetAllHandler,
    //ICommandHandler<GetPersonByIdQuery, GetPersonByIdQueryResult> GetByIdHandler 
  /*  ICommandHandler<PersonDeleteCommand> DeleteHandler*/)
    {
       // createHandler = CreateHandler;
       // getByIdHandler = GetByIdHandler;
    }
    //[HttpGet]
    //public IActionResult Get(int id)
    //{
    //    var query = new GetPersonByIdQuery
    //    {
    //        PersonId = id
    //    };
    //    var result = getByIdHandler.Handle(query);
    //    return Ok(result);
    //}

    [HttpGet("create")]
    public async Task<int> Create([FromServices]ICommandHandler<CreatePersonCommand, CreatePersonResult> createHandler, string name)
    {
        var command = new CreatePersonCommand
        {
            Name = name
        };
        var result = await createHandler.Handle(command);
        return result.PersonId;

    }
}
