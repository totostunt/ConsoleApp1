using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terciario.Models
{
    internal class Vino : Bebida , IBebidaAlcoholica //heredamos d bebida a vino
    {
        public Vino(int Cantidad, string Nombre = "Vino")
             : base(Nombre, Cantidad)
        {
        }
        public int alcohol { get; set; }
        public void maxRecomendado()
        {
            Console.WriteLine("El maximo permitido de vinos es dos botellas por persona")
        }
    }
}