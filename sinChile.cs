using system;
namespace recuperacion
{
 class sinChile: decorador 
    {
        public sinChile(baseorden pedido): base(pedido){}
        
        public override double calcularPrecioTotal()
        {
            return base.calcularPrecioTotal()+0;}

        
    }
}