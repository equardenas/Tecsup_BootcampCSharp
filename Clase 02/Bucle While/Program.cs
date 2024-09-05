// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa el número limite para el uso de los bucles");

int NumeroLimite = int.Parse(Console.ReadLine());
int Contador = 0;
Console.ReadLine();

Console.WriteLine("Bucle WHILE");
while (Contador < NumeroLimite) 
{
    Contador += 1;
    Console.WriteLine(Contador);
}
Console.ReadLine();

Console.WriteLine("Bucle DO - WHILE");
do
{
    Contador++;
    Console.WriteLine(Contador);
} while (Contador < NumeroLimite);

Console.ReadLine();


int Opcion = 0;
while (Opcion != 7) 
{
    Console.WriteLine("MENU DE LA CALCULADORA");
    Console.WriteLine("1.- Sumar");
    Console.WriteLine("2.- Restar");
    Console.WriteLine("3.- Multiplicar");
    Console.WriteLine("4.- Dividir");
    Console.WriteLine("5.- Potencia");
    Console.WriteLine("6.- Raiz");
    Console.WriteLine("7.- Salir");

    Console.WriteLine("Ingresa la opción :");
    Opcion = int.Parse(Console.ReadLine());
    if (Opcion == 1) 
    {
        Console.WriteLine("Sumando");
    }
    if (Opcion == 2)
    {
        Console.WriteLine("Restando");
    }
}

Console.WriteLine("Salida");