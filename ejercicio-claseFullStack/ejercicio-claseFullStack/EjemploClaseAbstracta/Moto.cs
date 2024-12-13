namespace ejercicio_claseFullStack.EjemploClaseAbstracta
{
    public class Moto: Vehiculo 
    {
        public Moto(string marca) : base(marca)
        {
            
        }
        public override string acelerar()
        {
            return "La moto se acelero";
        }
    }
}
