// Confeccionar un programa que permita cargar un número entero positivo 
//de hasta tres digitos y muestre un mensaje indicando si tiene 1, 2, o 3 dígitos. 
//Mostrar un mensaje de error si el número de dígitos es mayor

//Ejercicio 3 Numero entero 

class Program
{
    static void Main()
    {
        Console.Write("Ingresar un número entero positivo de hasta 3 dígitos ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0 && numero < 10)
            Console.WriteLine("El número tiene 1 dígito");
        else if (numero >= 10 && numero < 100)
            Console.WriteLine("El número tiene 2 dígitos");
        else if (numero >= 100 && numero < 1000)
            Console.WriteLine("El número tiene 3 dígitos");
        else
            Console.WriteLine("Error El número tiene más de 3 dígitos");
    }
}
