using system;
namespace recuperacion
{
    class chile: decorador
    {
        public chile(baseorden pedido): base(pedido){}
        
        public override double calcularPrecioTotal()
        {
            return base.calcularPrecioTotal()+0.50;

        }
    }
}