using Microsoft.AspNetCore.Mvc;
using test_APESA.WebService.Models;


namespace test_APESA.WebService.Controllers
{
    public class DatosController : Controller
    {
        private const string DATOS_PATH = @".\Data\Datos.txt";
        [HttpPost("EnviarDatos")]
        public IActionResult PostDatos([FromBody] DatosRequest datosRequest)
        {
            if (datosRequest == null)
            {
                return BadRequest("Fotmato Invalido");
            }
            if (!ModelState.IsValid)
            { 
                return BadRequest(ModelState);
            }
            try
            {
                string fila = $"{datosRequest.FcNombreCompleto}|" +
                    $"{datosRequest.FdFechaNacimiento}|" +
                    $"{datosRequest.FcCorreoElectronico}";
                System.IO.File.AppendAllLines(DATOS_PATH, new[] { fila });
                return Ok($"Datos Guardados Correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
        }
    }
}
