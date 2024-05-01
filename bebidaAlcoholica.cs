using System;

namespace practicaUNO.models
{
    interface IBebidaAlcoholica
    {
        public int alcohol { get; set; }

        public void maxRecomendado();
    }
}