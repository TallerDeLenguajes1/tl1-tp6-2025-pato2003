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

bool exit = true;
while (exit)
{
    bool opcion1;
    bool opcion2;
    Console.WriteLine("-------------Menu-------------\n1) Sumar\n2) Restar\n3) Multiplicar\n4) Dividir\n5) Salir\n------------------------------\nElija la operacion: ");
    int eleccion;
    
    if (!int.TryParse(Console.ReadLine(), out eleccion))
    {
        Console.WriteLine("No se ingresó un numero");
    }
    switch (eleccion)
    {
        case 1:
            Console.WriteLine("Ingrese el primer numero: ");
            opcion1 = int.TryParse(Console.ReadLine(), out num1);
            if (!opcion1)
            {
                Console.WriteLine("No se ingresó un numero");
                break;
            }

            Console.WriteLine("Ingrese el segundo numero: ");
            opcion2 = int.TryParse(Console.ReadLine(), out num2);
            if (!opcion2)
            {
                Console.WriteLine("No se ingresó un numero");
                break;
            }

            Console.WriteLine("RESULTADO = " + (num1 + num2));
            break;

        case 2:
            Console.WriteLine("Ingrese el primer numero: ");
            opcion1 = int.TryParse(Console.ReadLine(), out num1);
            if (!opcion1)
            {
                Console.WriteLine("No se ingresó un numero");
                break;
            }

            Console.WriteLine("Ingrese el segundo numero: ");
            opcion2 = int.TryParse(Console.ReadLine(), out num2);
            if (!opcion2)
            {
                Console.WriteLine("No se ingresó un numero");
                break;
            }

            Console.WriteLine("RESULTADO = " + (num1 - num2));
            break;

        case 3:
            Console.WriteLine("Ingrese el primer numero: ");
            opcion1 = int.TryParse(Console.ReadLine(), out num1);
            if (!opcion1)
            {
                Console.WriteLine("No se ingresó un numero");
                break;
            }

            Console.WriteLine("Ingrese el segundo numero: ");
            opcion2 = int.TryParse(Console.ReadLine(), out num2);
            if (!opcion2)
            {
                Console.WriteLine("No se ingresó un numero");
                break;
            }

            Console.WriteLine("RESULTADO = " + (num1 * num2));
            break;

        case 4:
            Console.WriteLine("Ingrese el primer numero: ");
            opcion1 = int.TryParse(Console.ReadLine(), out num1);
            if (!opcion1)
            {
                Console.WriteLine("No se ingresó un numero");
                break;
            }

            Console.WriteLine("Ingrese el segundo numero: ");
            opcion2 = int.TryParse(Console.ReadLine(), out num2);
            if (!opcion2)
            {
                Console.WriteLine("No se ingresó un numero");
                break;
            }

            Console.WriteLine("RESULTADO = " + (float)(num1 / num2));
            break;

        default:
            exit = false;
            break;
    }
    
}