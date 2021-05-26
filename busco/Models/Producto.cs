using System.Collections.Generic;

namespace busco.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; } 
        public Categoria Categoria { get; set; }

        // 
        public int categoriaId { get; set; }
      
    }
}