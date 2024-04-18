
using _6C_EPAM;

Cars Mazda = new Cars("Mazda Miata", 250);
Cars MercedesBenz = new Cars("Mercedes-Benz Vito", 400);

if (Mazda.Max_Velocity > MercedesBenz.Max_Velocity)
{
    Console.WriteLine($"{Mazda.Name} швидша за {MercedesBenz.Name}");
}

else if (MercedesBenz.Max_Velocity > Mazda.Max_Velocity)
{
    Console.WriteLine($"{MercedesBenz.Name} швидша за {Mazda.Name}");
}

else
{
    Console.WriteLine("Визначити найшвидшу машину неможливо");
}