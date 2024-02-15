using Microsoft.AspNetCore.Mvc;

namespace ModularMonolith.Modules.Conferences.Api.Controller;

[ApiController]
[Route(BasePath + "/[controller]")]
internal class BaseController : ControllerBase
{
    protected const string BasePath = "conferences-module";
}