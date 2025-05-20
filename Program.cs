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



//funciones
