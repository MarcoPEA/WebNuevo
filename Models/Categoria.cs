
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProyectoW.Models
{
     public class Categorias
    {
       public int Id { get; set; }
        public string Nombrecategoria { get; set; }
         public List<Producto> Pedido { get; set; }

    }
}