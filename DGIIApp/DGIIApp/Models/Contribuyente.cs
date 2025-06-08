using System.ComponentModel.DataAnnotations;

namespace DGIIApp.Models
{
    public class Contribuyente
    {
        [Key]
        public string RncCedula { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Estatus { get; set; }

        public ICollection<ComprobanteFiscal>? Comprobantes { get; set; }


    }
}
