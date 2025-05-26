int num;
Console.WriteLine("Ingrese un numero: ");
bool opcion = int.TryParse(Console.ReadLine(), out num);
if (!opcion)
{
    Console.WriteLine("No se ingreso un numero valido");
}

Console.WriteLine("Valor Absoluto: " + Math.Abs(num));
Console.WriteLine("Cuadrado: " + Math.Pow(num, 2));
Console.WriteLine("Raiz Cuadrada: " + Math.Sqrt(num));
Console.WriteLine("Seno: " + Math.Sin(num));
Console.WriteLine("Coseno: " + Math.Cos(num));
Console.WriteLine("Parte Real: " + Math.Truncate((float)num));


int num1, num2;
Console.WriteLine("\n\n\nIngrese 2 numeros:\n\nIngrese el primer numero: ");
opcion = int.TryParse(Console.ReadLine(), out num1);
if (!opcion)
{
    Console.WriteLine("No se ingreso un numero valido");
}

Console.WriteLine("Ingrese el segundo numero: ");
opcion = int.TryParse(Console.ReadLine(), out num2);
if (!opcion)
{
    Console.WriteLine("No se ingreso un numero valido");
}

Console.WriteLine("Maximo: " + Math.Max(num1, num2) + "\nMinimo: " + Math.Min(num1,num2));
