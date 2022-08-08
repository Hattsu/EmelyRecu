using System;

namespace recuperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            var orden1=new burrito();
            Console.WriteLine($"el precio del burritoes:{orden1.calcularPrecioTotal()}");
            var carne=new carne(orden1);
            Console.WriteLine($"el precio de la carne es:{carne.calculaPrecioTotal()}");
            Console.WriteLine("");
            Console.WriteLine("......................")

            var orden2=new tacos();
            Console.WriteLine($"el precio del taco:{orden2.calcularPrecioTotal()}");
            var pollo=new pollo(orden2);
            Console.WriteLine($"el precio de la pollo es:{pollo.calculaPrecioTotal()}");
            Console.WriteLine("");
            Console.WriteLine("......................")

            var orden3=new chile();
            Console.WriteLine($"el precio del chile:{orden2.calcularPrecioTotal()}");
            var sinChile=new sinChile(orden3);
            Console.WriteLine($"el precio del sinchile es:{sinchile.calculaPrecioTotal()}");
            Console.WriteLine("");
            Console.WriteLine("......................")



        }
    }
}
