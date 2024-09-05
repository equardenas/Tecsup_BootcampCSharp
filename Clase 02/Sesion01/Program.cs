// See https://aka.ms/new-console-template for more information
using System;

string nombre = "Edgar Cárdenas Navarro";
int edad = 20;
long altura = 165;
double dinero = 1651.36;
float danio = 124.4f;
decimal montoEnBanco = 12451651.4m;
char letra = 'A';
bool TieneGorro = false;
var kilometros = 251531.5454;

Console.WriteLine("Escribe tu nombre");
nombre = Console.ReadLine();

Console.WriteLine("Escribe tu edad");
edad = int.Parse(Console.ReadLine());

Console.WriteLine("Mi nombre es " + nombre + ", mi edad es " + edad);
Console.WriteLine($"Mi altura es {altura}");

if (edad >= 18) {
    Console.WriteLine("Puedes ingresar, eres mayor de edad");
}
else if (edad >= 15) {
    Console.WriteLine("Casi llegas");
}
else {
    Console.WriteLine("No puedes ingresar chiquillo, ve a tu casa");
}
Console.WriteLine("Tienes gorro??");

string respuestaGorro = Console.ReadLine();
if (respuestaGorro == "si") { TieneGorro = true; }
else { TieneGorro = false; }

if (TieneGorro == true) { Console.WriteLine("Tienes gorro, bien por Ti"); }