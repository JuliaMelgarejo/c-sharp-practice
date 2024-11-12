using Microsoft.AspNetCore.Razor.Hosting;

namespace ejercicio_claseFullStack.herencia
{
    public class Animal
    {
        public string raza {  get; set; }

        public  virtual string comida()
        {
            return "este animal come comida";
        }
    }
}
