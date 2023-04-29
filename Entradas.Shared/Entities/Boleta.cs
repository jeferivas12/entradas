
using System.ComponentModel.DataAnnotations;


namespace Entradas.Shared.Entities
{
    public class Boleta
    {
        
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        [Display(Name = "Fecha/Hora")]
        public DateTime Date { get; set; }

        [Display(Name = "Usada")]
        public bool Usada { get; set; }

        [Display(Name = "Portería")]
        [MaxLength(10, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string? Porteria { get; set; }





    }

}

