
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using SampleCQRS.Core.ApplicationServices.Persons.CreatePerson;
using SampleCQRS.Core.ApplicationServices.Persons.DeletePerson;
using SampleCQRS.Core.ApplicationServices.Persons.EditPerson;
using SampleCQRS.Core.ApplicationServices.Persons.GetPerson;
using SampleCQRS.Core.Domain.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EndPoint.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Person3Controller : ControllerBase
{
    private readonly IMediator _mediator;

    // private readonly ICommandHandler<CreatePersonCommand, CreatePersonResult> createHandler;
   // private readonly ICommandHandler<GetPersonByIdQuery, GetPersonByIdQueryResult> getByIdHandler;

    public Person3Controller(
        IMediator mediator
  //ICommandHandler<EditPersonCommand, EditPersonResult> EditHandler ,
  //ICommandHandler<GetAllPersonQuery, GetAllPersonQueryResult> GetAllHandler,
  //ICommandHandler<GetPersonByIdQuery, GetPersonByIdQueryResult> GetByIdHandler 
  /*  ICommandHandler<PersonDeleteCommand> DeleteHandler*/)
    {
        // createHandler = CreateHandler;
        // getByIdHandler = GetByIdHandler;
        _mediator = mediator;
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _mediator.Send(new GetPersonByIdQuery { PersonId = id });
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpGet("create")]
    public async Task<int> Create( string name)
    {
        var command = new CreatePersonCommand
        {
            Name = name
        };
        var result = await _mediator.Send(command);
        return result.PersonId;

    }
}
