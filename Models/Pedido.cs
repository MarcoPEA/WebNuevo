using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace ProyectoW.Models
{
    public class Pedido
    {
        public int Id { get; set; }
         public int Cantidad { get; set; }
        public decimal Inporte { get; set; }
         public List<Detalle> Detalle { get; set; }
      
    }
}