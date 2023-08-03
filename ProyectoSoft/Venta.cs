using System;

namespace CompaniaAutos
{
    class Venta
    {
        public string MarcaAuto { get; set; }
        public string ModeloAuto { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
