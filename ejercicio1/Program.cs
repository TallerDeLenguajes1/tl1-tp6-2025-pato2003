int num;
Console.WriteLine("Ingrese un numero: ");
bool opcion = int.TryParse(Console.ReadLine(), out num);
if (!opcion)
{
    Console.WriteLine("No se ingreso un numero valido");
}

Console.WriteLine(Math.Abs(num));
Console.WriteLine(Math.Pow(num, 2));
Console.WriteLine(Math.Sqrt(num));
Console.WriteLine(Math.Sin(num));
Console.WriteLine(Math.Cos(num));
Console.WriteLine(Math.Truncate((float)num));


int num1, num2;
Console.WriteLine("Ingrese un nuevo numero: ");
opcion = int.TryParse(Console.ReadLine(), out num1);
if (!opcion)
{
    Console.WriteLine("No se ingreso un numero valido");
}

Console.WriteLine("Ingrese un nuevo numero: ");
opcion = int.TryParse(Console.ReadLine(), out num2);
if (!opcion)
{
    Console.WriteLine("No se ingreso un numero valido");
}

Console.WriteLine("Maximo: " + Math.Max(num1, num2) + "\nMinimo: " + Math.Min(num1,num2));
