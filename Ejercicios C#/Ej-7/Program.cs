//Desarrollar un programa que permita cargar n números enteros y 
//luego nos informe cuántos valores fueron pares y cuántos impares.


// Ejercicio 7 Numeros enteros

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de números ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int pares = 0, impares = 0;
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingrese un número ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine("Cantidad de números pares " + pares);
        Console.WriteLine("Cantidad de números impares " + impares);
    }
}
