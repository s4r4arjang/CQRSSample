//using EndPoint.Api.AppService.Persons.Contracts;
//using EndPoint.Api.AppService.Persons.GetPerson;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace EndPoint.Api.Controllers;

//[Route("api/[controller]")]
//[ApiController]
//public class PersonController : ControllerBase
//{
//    private readonly IPersonService _personService;

//    public PersonController(IPersonService personService)
//    {
//        this._personService = personService;
//    }
//    public IActionResult Get(int id)
//    {
//        var query = new GetPersonByIdQuery
//        {
//            PersonId = id
//        };
//        var result = _personService.GetPerson(query);
//        return Ok(result);
//    }
//}
