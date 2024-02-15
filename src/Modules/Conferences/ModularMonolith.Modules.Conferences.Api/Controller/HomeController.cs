using Microsoft.AspNetCore.Mvc;

namespace ModularMonolith.Modules.Conferences.Api.Controller;

[Route(BasePath)]
internal class HomeController : BaseController
{
    [HttpGet]
    public ActionResult<string> Get() => "Conferences module";
}