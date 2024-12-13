namespace ejercicio_claseFullStack.EjemploClaseAbstracta
{
    public class Gato: Animal
    {
        public Gato(string raza): base(raza) 
        {
            
        }
        public override string comida()
        {
            return "este gato come comida";
        }
    }
}
