bool exit = true;
while (exit)
{
    int num1;
    int num2;
    bool opcion1;
    bool opcion2;
    Console.WriteLine("-------------Menu-------------\n1) Sumar\n2) Restar\n3) Multiplicar\n4) Dividir\n5) Salir\n------------------------------\nElija la operacion: ");
    int opcion;
    
    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("No se ingresó un numero");
    }
    switch (opcion)
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