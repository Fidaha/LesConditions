namespace LesConditions;
using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {

    // Fais saisir à l'utilisateur deux valeurs entières : un minimum et un maximum.
    // Fais saisir un troisième entier à l'utilisateur et borne-le au maximum et au minimum.

    int min, max, val;

        Console.WriteLine("Entrez la valeur minimale : ");
        min = int.Parse(Console.ReadLine());

        Console.WriteLine("Entrez la valeur maximale : ");
        max = int.Parse(Console.ReadLine());

        Console.WriteLine("Entrez une valeur : ");
        val = int.Parse(Console.ReadLine());

if (val < min)
{
    val = min;
}
else if (val > max)
{
    val = max;
}

        Console.WriteLine("La valeur saisie est : " + val);



        
    }
}
