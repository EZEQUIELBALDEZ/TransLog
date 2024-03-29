using Microsoft.AspNetCore.Mvc;

using Backend.Models.Request;
using Backend.Models.Response;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Backend.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class FreteController : ControllerBase
    {
        decimal valorQuilometro = 0.50m;
        decimal adicionalQuilo = 1.00m;
        decimal adicionaloCubico = 2.00m;
        [HttpGet]
        [Route("obter")]

        public IActionResult Obter ([FromQuery] CargaRequest request)
        {

            //   A fórmula para calcular o custo do frete é a seguinte: Custo do Frete = (Distância × Valor Fixo por
            //Km) +(Peso × Valor Adicional por Kg) +(Largura × Altura × Valor Adicional por m3)





            var ValorFrete = (Distancia.request * valorQuilometro) + (Peso.request * adicionalQuilo) + (Largura.request * Altura.request * adicionaloCubico);



            var response = new cargaResponse();
            response.ValorDotransporte = ValorFrete;


            return Ok(response);

        }
    }
}
