using Microsoft.AspNetCore.Mvc;

using Backend.Models.Request;
using Backend.Models.Response;

namespace Backend.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class FreteController : ControllerBase
    {

        [HttpGet]
        [Route("obter")]
        public IActionResult ObterCarga ([FromQuery] CargaRequest request)
        {

            //Se o pessoa nasceu antes de 1920, a data de nascimento está errada teoricamente ninguem
            //vivo nasceu antes de 1920

            decimal valorQuilometro = 0.50m;
            decimal adicionalQuilo = 1.00m;
            decimal adicionaloCubico = 2.00m;

            var ValorFrete;




            return Ok(response);

        }
    }
}
