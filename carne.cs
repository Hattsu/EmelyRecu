using system;
namespace recuperacion
{
    class carne: decorador
    {
       public carne (baseorden pedido): base(pedido){
        public override double calcularPrecioTotal(){
            return base.calcularPrecioTotal()+1.00;
        }
    }
}
}