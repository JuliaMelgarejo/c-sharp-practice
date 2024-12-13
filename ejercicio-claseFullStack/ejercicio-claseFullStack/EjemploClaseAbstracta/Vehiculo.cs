namespace ejercicio_claseFullStack.EjemploClaseAbstracta
{
    public abstract class Vehiculo
    {
        public int marca { get; set; }
        protected Vehiculo(string marca)
        {
            
        }
        public abstract string acelerar();

        public string DistanciaRecorrida()
        {
            return "El vehiculo recorrio 20km ";
        }
    }
}
