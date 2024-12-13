namespace ejercicio_claseFullStack.EjemploClaseAbstracta
{
    public class Perro: Animal
    {
        public Perro(string raza) : base(raza)
        {

        }
        public override string comida()
        {
            return "este perro come comida";
        }
    }
}
