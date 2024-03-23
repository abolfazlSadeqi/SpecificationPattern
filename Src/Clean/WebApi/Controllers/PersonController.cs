using App;
using Domain.Entites.Persons;
using Domain.interfaces;
using Infra.EF.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class PersonController : Controller
{
    public readonly IPersonApp _service;
    public PersonController(IPersonApp service)
    {
        _service = service;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
         => Ok(await _service.GetAllByLegalAgeAndCurrentDate());


    [HttpGet("Add")]
    public async Task<IActionResult> Add(string firstName, string lastName, int age, int cityId)
    {
        await _service.Add(new Person(firstName, lastName, age, cityId));
        return Ok();
    }

    [HttpGet("GetPersonByLastnameArdalis")]
    public async Task<IActionResult> GetPersonByLastnameArdalis()
        => Ok(await _service.GetPersonByLastnameArdalis("fgf"));


    [HttpGet("GetByCityId")]
    public async Task<IActionResult> GetByCityId()
       => Ok(await _service.GetByCityId(1));



}
