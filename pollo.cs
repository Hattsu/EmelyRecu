using system;
namespace recuperacion
{
    class pollo:decorador
    {
    public pollo(baseorden pedido): base(pedido){}
        
        public override double calcularPrecioTotal()
        {
            return base.calcularPrecioTotal()+0.50;
        }
    }

}