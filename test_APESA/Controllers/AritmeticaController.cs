using Microsoft.AspNetCore.Mvc;

namespace test_APESA.WebService.Controllers
{
    public class AritmeticaController : Controller
    {

        [HttpGet("Sumar")]
        public IActionResult GetSumar(int piNum1, int piNum2)
        {
            return Ok(piNum1 + piNum2);
        }
    }
}
