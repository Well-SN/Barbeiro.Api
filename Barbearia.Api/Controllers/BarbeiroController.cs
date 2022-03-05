using Barbearia.Shareable.Requests;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Barbearia.Api.Controllers;
[Route("api/v1/barbeiros")]

public class BarbeiroController : Controller {
    [HttpPost]
    public async Task<IActionResult> CriarBarbeiro([FromBody,Required] CriarBarbeiroRequest criarBarbeiroRequest) {

    }

}

