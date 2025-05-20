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

//EJERCICIO 2
bool salir = false;

do
{
    menu();
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            suma();
            break;
        case "2":
            resta();
            break;
        case "3":
            Multiplicacion();
            break;
        case "4":
            division();
            break;
        case "0":
            salir = true;
            Console.WriteLine("Saliendo....");
            break;
    }

} while (!salir);





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
    Console.WriteLine("Elija una opcion");
    Console.WriteLine("1_ Suma");
    Console.WriteLine("2_ Resta");
    Console.WriteLine("3_ Multiplicacion");
    Console.WriteLine("4_ Division");
    Console.WriteLine("0_ Salir");
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

    Console.WriteLine("El resultado de la division es: "+ resultado);
}