using System.ComponentModel.DataAnnotations;

namespace Farmacia.modelos
{
    public class productos /*Nombre de la tabla */
    {
        [Key]

        public int id { get; set; }/* Nombre de los campos en la BD */
        [Required]

        [Display(Name = "Nombre Producto")]  /* Nombre para llamarlos desde el FRONT */
        public string nombreProducto{ get; set; }/* Nombre de los campos en la BD */

        [Display(Name = "Tipo presentacion del producto")] /* Nombre para llamarlos desde el FRONT */
        public string presentacionProducto { get; set; } /* Nombre de los campos en la BD */ 

        [Display(Name = "Precio del producto")] /* Nombre para llamarlos desde el FRONT */
        public int precioProducto { get; set; } /* Nombre de los campos en la BD */

        [Display(Name="fecha de vencimiento")] /* Nombre para llamarlos desde el FRONT */
        public DateTime  fechaVencimiento { get; set; } /* Nombre de los campos en la BD */
    }
}
