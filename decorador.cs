using system;
namespace recuperacion 
{
    class decorador: baseorden
    {
        protected baseorden pedido;
        public decorador(baseorden pedido)
        {
            this.pedido=pedido;
        }
        public virtual double calcularPrecioTotal()
        {
            Console.WriteLine("calcular el pedido desde el decorador")
            return.pedido.calcularPrecioTotal();
        }

    }
}