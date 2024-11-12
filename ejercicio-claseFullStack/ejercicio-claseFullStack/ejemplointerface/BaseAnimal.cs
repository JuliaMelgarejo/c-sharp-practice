namespace ejercicio_claseFullStack.ejemplointerface
{
    public class BaseAnimal
    {
        public string raza(IAnimal animal)
        {
            return animal.raza();
        }
    }
}
