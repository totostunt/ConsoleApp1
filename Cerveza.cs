namespace Terciario.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica //heredamos d bebida a vino
    {
        public Cerveza(int Cantidad, string Nombre = "Vino")
             : base(Nombre, Cantidad)
        {
     
        }
        public Cerveza()
        public int alcohol { get; set; }
        public void maxRecomendado()
        {
            Console.WriteLine("El maximo permitido de vinos es dos botellas por persona")
        }
    }
}