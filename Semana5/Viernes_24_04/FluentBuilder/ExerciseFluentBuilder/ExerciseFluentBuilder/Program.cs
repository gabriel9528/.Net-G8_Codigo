using ExerciseFluentBuilder;

public class Program
{
    static void Main(string[] args)
    {
        var sandwichBuilder = new SandwichBuilder()
            .AgregarPan()
            .AgregarVerduras()
            .AgregarCondimentos()
            .Build();

        Console.Write("Sandwich creado: ");
        Console.Write(sandwichBuilder);
    }
}