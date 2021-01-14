using Microsoft.AspNetCore.Mvc;
using petroleumAPI.Models;
using petroleumAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petroleumAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CampoController : ControllerBase
  {
    private readonly CampoService _campoService;
    public CampoController(CampoService campoService)
    {
      _campoService = campoService;
    }
    [HttpGet]
    public ActionResult<List<Campos>> Get() =>
        _campoService.Get();

    [HttpGet("{id:length(24)}", Name = "GetCampo")]
    public ActionResult<Campos> Get(string id)
    {
      var campo = _campoService.Get(id);

      if (campo == null)
      {
        return NotFound();
      }

      return campo;
    }

    [HttpPost]
    public ActionResult<Campos> Create(Campos campo)
    {
      _campoService.Create(campo);

      return CreatedAtRoute("GetCampo", new { id = campo.Id.ToString() }, campo);
    }

    [HttpPut("{id:length(24)}")]
    public IActionResult Update(string id, Campos campoIn)
    {
      var campo = _campoService.Get(id);

      if (campo == null)
      {
        return NotFound();
      }

      _campoService.Update(id, campoIn);

      return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public IActionResult Delete(string id)
    {
      var campo = _campoService.Get(id);

      if (campo == null)
      {
        return NotFound();
      }

      _campoService.Remove(campo.Id);

      return NoContent();
    }

  }
}
