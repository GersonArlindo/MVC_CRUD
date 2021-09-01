using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VGStore.Models
{
    public class Categorias
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required]
        [DisplayName("Nombre de Categoria")]
        public string Nombre { get; set; }
        [Required]
        [Range(1, int.MaxValue,ErrorMessage="El valor tiene que ser mayor que 0")]
        public int Orden { get; set; }
    }
}
