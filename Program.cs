// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);

//Ejercicio 1

int i = 0;

Console.WriteLine("Ingrese un numero mayor que 0");
string numero = Console.ReadLine();
bool esNumero = int.TryParse(numero, out i);

if (esNumero == true)
{
    if (i > 0)
    {
        int invertido = 0;
        Console.WriteLine("El numero ingresado es: " + i);
        while (i > 0)
        {
            int digito = i % 10;
            invertido = invertido * 10 + digito;
            i /= 10;
        }
        Console.WriteLine("El numero invertido es: " + invertido);
    }
    else
    {
        Console.WriteLine("El numero ingresado debe ser mayor que 0");
    }
}
else
{
    Console.WriteLine("El valor ingresado no es un numero");
}

// CADENA

//*1
Console.WriteLine("Ingrese una palabra: ");
string palabra = Console.ReadLine();
int longitud = palabra.Length;
Console.WriteLine("Longitud de la cadena: " + longitud);

//*2
Console.WriteLine("Ingrese una segunda palabra: ");
string palabra2 = Console.ReadLine();
string concatenada = $"{palabra}, {palabra2}";
Console.WriteLine("La palabra concatenada es: " + concatenada);

//funciones
double LeerNumero(string mensaje)
{
    double numero;
    Console.WriteLine(mensaje);
    while (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Error, ingrese un numero");
    }
    return numero;
}
void menu()
{
    Console.WriteLine("=== CALCULADORA BASICA ===");
    Console.WriteLine("Elija una opcion");
    Console.WriteLine("1_ Suma");
    Console.WriteLine("2_ Resta");
    Console.WriteLine("3_ Multiplicacion");
    Console.WriteLine("4_ Division");
    Console.WriteLine("5_ Operaciones varias");
    Console.WriteLine("6_ Valor Max y Min de entre dos numeros");
    Console.WriteLine("0_ Salir");
    Console.WriteLine("=========================");
}

void suma()
{
    double num1 = LeerNumero("Ingrese primer numero: ");
    double num2 = LeerNumero("Ingrese segundo numero: ");

    double resultado = num1 + num2;
    Console.WriteLine("El resultado de la suma es: " + resultado);
}

void resta()
{
    double num1 = LeerNumero("Ingrese primer numero: ");
    double num2 = LeerNumero("Ingrese segundo numero: ");

    double resultado = num1 - num2;
    Console.WriteLine("El resultado de la resta es " + resultado);
}

void Multiplicacion()
{
    double num1 = LeerNumero("Ingrese primer numero: ");
    double num2 = LeerNumero("Ingrese segundo numero: ");

    double resultado = num1 * num2;
    Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
}

void division()
{
    double num1 = LeerNumero("Ingrese primer numero: ");
    double num2 = LeerNumero("Ingrese segundo numero distinto de 0: ");
    double resultado = 0;

    if (num2 != 0)
    {
        resultado = num1 / num2;
    }
    else if (num2 == 0)
    {
        Console.WriteLine("No se puede dividir por 0");
    }

    Console.WriteLine("El resultado de la division es: " + resultado);
}

void Operaciones()
{
    double num = LeerNumero("Ingrese un numero: ");
    double potencia = Math.Pow(num, 2);
    double absoluto = Math.Abs(num);
    double seno = Math.Sin(num);
    double coseno = Math.Cos(num);
    double entero = Math.Truncate(num);

    

    Console.WriteLine("El valor absoluto del numero: " + absoluto);
    Console.WriteLine("El cuadrado del numero: " + potencia);
    if (num > 0)
    {
        double raiz = Math.Sqrt(num);
        Console.WriteLine("Raiz cuadrada del numero: " + raiz);
    }
    else
    {
        Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo");
    }
    Console.WriteLine("El seno del numero: " + seno);
    Console.WriteLine("El coseno del numero: " + coseno);
    Console.WriteLine("El entero del numero(si es decimal): " + entero);
}

void Max_Min()
{
    double num1 = LeerNumero("Ingrese primer numero: ");
    double num2 = LeerNumero("Ingrese segundo numero: ");

    double max = Math.Max(num1, num2);
    double min = Math.Min(num1, num2);

    Console.WriteLine("El numero maximo es: " + max);
    Console.WriteLine("El numero minimo es: " + min);
}