using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class VehiculoBase
    {
        [Required(ErrorMessage = "La placa es requerida")]
        [RegularExpression(@"[A-Za-z]{3}-[0-9]{3}", ErrorMessage = "El formato de la placa debe ser ###-ABC")]
        public string Placa { get; set; }


        [Required(ErrorMessage = "El color es requerido")]
        [StringLength(20, ErrorMessage = "La propiedad color debe ser mayor a 4 caracteres y menos a 20", MinimumLength = 4)]
        public string Color { get; set; }


        [Required(ErrorMessage = "El Anio es requerido")]
        [RegularExpression(@"(19|20)\d\d", ErrorMessage = "El formato del año no es válido")]
        public int Anio { get; set; }


        [Required(ErrorMessage = "El Precio es requerido")]
        public Decimal Precio { get; set; }


        [Required(ErrorMessage = "El Correo es requerido")]
        [EmailAddress]
        public string CorreoPropietario { get; set; }


        [Required(ErrorMessage = "El Telefono es requerido")]
        [Phone]
        public string TelefonoPropietario { get; set; }
    }

    public class VehiculoRequest : VehiculoBase
    {
        [Required(ErrorMessage = "El modelo es requerido")]
        public Guid IdModelo { get; set; }
    }

    public class VehiculoResponse : VehiculoBase
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
    }

    public class VehiculoDetalle : VehiculoResponse
    {
        public bool RevisionValida { get; set; }
        public bool RegistroValido { get; set; }
    }
}
