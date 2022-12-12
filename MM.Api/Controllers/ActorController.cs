using Microsoft.AspNetCore.Mvc;
using MM.Domain.Repositories;

namespace MM.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ActorController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public ActorController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    // GET
    [HttpGet]
    public IActionResult Get()
    {
        return Ok( _unitOfWork.Actors.GetActorsWithMovies());
    }
}