namespace ejercicio_claseFullStack.EjemploClaseAbstracta
{
    public class Auto: Vehiculo
    {
        public Auto(string marca): base(marca) 
        {
            
        }
        public override string acelerar()
        {
            return "El auto se acelero";
        }
    }
}
