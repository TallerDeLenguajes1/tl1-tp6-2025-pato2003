
int pedirNumero()
{
    int num1;
    Console.WriteLine("Ingrese el numero: ");
    bool control1 = int.TryParse(Console.ReadLine(), out num1);
    while (!control1)
    {
        Console.WriteLine("No se ingresó un numero. Ingrese de vuelta");
        control1 = int.TryParse(Console.ReadLine(), out num1);
    }
    return num1;
}

int sumar(int num1, int num2)
{
    return num1 + num2;
}

int restar(int num1, int num2)
{
    return num1 - num2;
}

int multiplicar(int num1, int num2)
{
    return num1 * num2;
}
int dividir(int num1, int num2)
{
    return num1 / num2;
}

string calculadora(int eleccion)
{
    int num1, num2;
    switch (eleccion)
    {
        case 1:
            num1 = pedirNumero();
            num2 = pedirNumero();
            return "La suma de "+num1.ToString()+" y de "+num2.ToString()+" es igual a: "+sumar(num1,num2).ToString();

        case 2:
            num1 = pedirNumero();
            num2 = pedirNumero();
            return "La resta de "+num1.ToString()+" y de "+num2.ToString()+" es igual a: "+restar(num1,num2).ToString();


        case 3:
            num1 = pedirNumero();
            num2 = pedirNumero();
            return "El producto de "+num1.ToString()+" y de "+num2.ToString()+" es igual a: "+multiplicar(num1,num2).ToString();


        case 4:
            num1 = pedirNumero();
            num2 = pedirNumero();
            return "El cociente de "+num1.ToString()+" y de "+num2.ToString()+" es igual a: "+dividir(num1,num2).ToString();



        default:
            return "Número inválido\n";
    }
}

void menu()
{
    Console.WriteLine("-------------Menu-------------\n1) Sumar\n2) Restar\n3) Multiplicar\n4) Dividir\n5) Salir\n------------------------------\nElija la operacion");
}

int num = pedirNumero();

Console.WriteLine("Valor Absoluto: " + Math.Abs(num));
Console.WriteLine("Cuadrado: " + Math.Pow(num, 2));
Console.WriteLine("Raiz Cuadrada: " + Math.Sqrt(num));
Console.WriteLine("Seno: " + Math.Sin(num));
Console.WriteLine("Coseno: " + Math.Cos(num));
Console.WriteLine("Parte Real: " + Math.Truncate((float)num));



Console.WriteLine("\n\n\nIngrese 2 numeros:\n\n");
int num1 = pedirNumero();
int num2 = pedirNumero();


Console.WriteLine("Maximo: " + Math.Max(num1, num2) + "\nMinimo: " + Math.Min(num1,num2));

menu();
int eleccion = pedirNumero();
while (eleccion >=1 && eleccion <= 4)
{
    calculadora(eleccion);
    menu();
    eleccion = pedirNumero();
}


Console.WriteLine("Ingrese un texto: ");
string cadena1 = Console.ReadLine();
Console.WriteLine("Longitud:" + cadena1.Length);

Console.WriteLine("Ingrese otro texto: ");
string cadena2 = Console.ReadLine();
string cadenaConcatenada = cadena1 + cadena2;
Console.WriteLine($"Cadenas concatenadas: {cadenaConcatenada}\n\n");

string subCadena = cadenaConcatenada.Substring(2, 3);
Console.WriteLine($"SubCadena del segundo texto: {subCadena}\n\n");


menu();
eleccion = pedirNumero();
calculadora(eleccion);




foreach (char item in cadena2)
{
    Console.WriteLine(item);
}


bool contienePunto = cadena2.Contains('.');
if (contienePunto)
{
    Console.WriteLine("La cadena: " + cadena2 + " SI contiene punto");
}
else
{
    Console.WriteLine("La cadena: " + cadena2 + " NO contiene punto");
}


Console.WriteLine($"Cadena 2 mayuscula: {cadena2.ToUpper()}\n");
Console.WriteLine($"Cadena 2 mayuscula: {cadena2.ToLower()}\n");



// split
Console.WriteLine("Ingrese un arreglo de elementos separados por ',': ");
string cadenaConSeparador = Console.ReadLine();
string[] cadenasSeparadas = cadenaConSeparador.Split('.');

foreach (var palabra in cadenasSeparadas)
{
    Console.WriteLine($"[{palabra}]");
}

Console.WriteLine("Ingrese una ecuación simple(suma, resta, multiplicacion o division): ");
string ecuacion = Console.ReadLine();
if (ecuacion.Contains('+'))
{
    string[] numeros = ecuacion.Split('+');
    int num01, num02;
    bool control01 = int.TryParse(numeros[0], out num01);
    bool control02 = int.TryParse(numeros[0], out num02);
    if (!control01)
    {
        Console.WriteLine("No se ingreso un numero\n");
    }
    if (!control02)
    {
        Console.WriteLine("No se ingreso un numero\n");
    }

    Console.WriteLine("La resta de " + num01.ToString() + " y de " + num02.ToString() + " es igual a: " + restar(num01, num02).ToString());

} else if (ecuacion.Contains('-'))
{
    string[] numeros = ecuacion.Split('-');
    int num01, num02;
    bool control01 = int.TryParse(numeros[0], out num01);
    bool control02 = int.TryParse(numeros[0], out num02);
    if (!control01)
    {
        Console.WriteLine("No se ingreso un numero\n");
    }
    if (!control02)
    {
        Console.WriteLine("No se ingreso un numero\n");
    }

    Console.WriteLine("La suma de " + num01.ToString() + " y de " + num02.ToString() + " es igual a: " + sumar(num01, num02).ToString());
} else if(ecuacion.Contains('*'))
{
    string[] numeros = ecuacion.Split('*');
    int num01, num02;
    bool control01 = int.TryParse(numeros[0], out num01);
    bool control02 = int.TryParse(numeros[0], out num02);
    if (!control01)
    {
        Console.WriteLine("No se ingreso un numero\n");
    }
    if (!control02)
    {
        Console.WriteLine("No se ingreso un numero\n");
    }

    Console.WriteLine("El producto de " + num01.ToString() + " y de " + num02.ToString() + " es igual a: " + multiplicar(num01, num02).ToString());
}else
{
    string[] numeros = ecuacion.Split('*');
    int num01, num02;
    bool control01 = int.TryParse(numeros[0], out num01);
    bool control02 = int.TryParse(numeros[0], out num02);
    if (!control01)
    {
        Console.WriteLine("No se ingreso un numero\n");
    }
    if (!control02)
    {
        Console.WriteLine("No se ingreso un numero\n");
    }

    Console.WriteLine("El cociente de " + num01.ToString() + " y de " + num02.ToString() + " es igual a: " + dividir(num01, num02).ToString());
}
