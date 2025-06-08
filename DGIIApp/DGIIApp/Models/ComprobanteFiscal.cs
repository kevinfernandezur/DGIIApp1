using System.ComponentModel.DataAnnotations;


namespace DGIIApp.Models
{
    public class ComprobanteFiscal
    {

        [Key]
        public int Id { get; set; }

        public string RncCedula { get; set; }
        public string NCF { get; set; } = string.Empty;
        public decimal Monto { get; set; }
        public decimal Itbis18 { get; set; }


        public Contribuyente? Contribuyente { get; set; }


    }
}
