using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProyectoW.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Categorias Categoria { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public String Imagen { get; set; }
        public List<Detalle> Detalle { get; set; }
    }
}