﻿Console.WriteLine("hola vamos a jugar, tienes que adivinar un número del 1 al 15");
Random rnd = new Random();
int numero = rnd.Next(1,15);
int intentos = 2;

Console.WriteLine("escribe tu numero del 1 al 15");
int intento = Convert.ToInt32(Console.ReadLine());

while (intentos > 0)
{
    if (intento == numero)
    {
    Console.WriteLine("has acertado");
    }
    else if(numero < intento)
    {
        Console.WriteLine("el número es menor que el que tu piensas");
    }
    else if(numero > intento)
    {
        Console.WriteLine("el número es mayor que el que tu piensas");
    }
    intentos--;
    Console.WriteLine("prueba de nuevo");
    intento = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("has perdido");