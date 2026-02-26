using System.ComponentModel.DataAnnotations;

namespace test_APESA.WebService.Models
{
    public class DatosRequest
    {
        [Required(AllowEmptyStrings = false,ErrorMessage = "Campo Obligatorio*")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Solo se permiten caracteres alfabéticos")]
        public string FcNombreCompleto { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio*")]
        [DataType(DataType.Date,ErrorMessage = "Formato Incorrecto")]
        public DateTime FdFechaNacimiento  { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obligatorio*")]
        [EmailAddress(ErrorMessage = "Formato No Valido")]
        public string FcCorreoElectronico { get; set; }
    }
}
