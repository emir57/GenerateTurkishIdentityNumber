using GenerateTurkishIdentityNumber.Generators.Turkish;

Console.WriteLine("Count: ");

int count = int.Parse(Console.ReadLine()!);
for (int i = 0; i < count; i++)
{
    Console.WriteLine(TurkishIdentityGenerator.Generate());
}