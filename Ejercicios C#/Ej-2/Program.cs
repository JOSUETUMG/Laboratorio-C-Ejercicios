//Se debe desarrollar un programa que pida el ingreso del precio de un artículo y 
//la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.


//Ejercicio 2 Abono 

class Program
{
    static void Main()
    {
        Console.Write("Ingresar la cantidad el articulo ");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la cantidad que lleva el cliente ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        double total = precio * cantidad;
        Console.WriteLine("El total a abonar es " + total);
    }
}