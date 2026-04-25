using ExerciseBuilder.Builder;
using ExerciseBuilder.ConcreteBuilder;
using ExerciseBuilder.Director;
using ExerciseBuilder.Product;

public class Program
{
    static void Main(string[] args)
    {
        //Creamos el director
        SandwichAssembly director = new SandwichAssembly();

        //Configurar el constructor concreto
        SandwichBuilder cheeseBurger = new CheeseBurger();
        director.SetBuilder(cheeseBurger);

        //construir el sandwich
        director.Assembly();

        //Obtener el sandwich construido
        Sandwich sandwich = director.GetSandwich();

        Console.WriteLine("Sandwich construido");
        Console.WriteLine(sandwich);
        Console.ReadLine();
    }
}