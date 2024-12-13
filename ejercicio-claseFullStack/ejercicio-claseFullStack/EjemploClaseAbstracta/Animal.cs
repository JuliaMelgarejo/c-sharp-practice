namespace ejercicio_claseFullStack.EjemploClaseAbstracta
{
    public abstract class Animal
    {
        public string raza {  get; set; }
        protected Animal(string raza)
        {
            
        }
        public abstract string comida();

        public string Caracteristicas()
        {
            return "Tienen cuatro patas";
        }

    }
}
