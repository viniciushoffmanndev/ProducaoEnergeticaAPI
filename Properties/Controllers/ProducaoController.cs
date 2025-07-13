using Microsoft.AspNetCore.Mvc;

namespace CocalApi.Controllers;

[ApiController]
[Route("api/producao")]
public class ProducaoController : ControllerBase
{
    [HttpGet("etanol")]
    public IActionResult GetEtanol() =>
        Ok(new { data = "2025-07-10", quantidade_litros = 1500000 });

    [HttpGet("energia")]
    public IActionResult GetEnergia() =>
        Ok(new { data = "2025-07-10", quantidade_mwh = 12000 });

    [HttpGet("biometano")]
    public IActionResult GetBiometano() =>
        Ok(new { data = "2025-07-10", quantidade_nm3 = 50000 });

    [HttpGet("co2-verde")]
    public IActionResult GetCO2Verde() =>
        Ok(new { data = "2025-07-10", quantidade_toneladas = 300 });
}
