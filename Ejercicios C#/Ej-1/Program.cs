//Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo 
//(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)


//Ejercicio 1 Lado del Cuadrado

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor del Cuadrado ");
        double lado = Convert.ToDouble(Console.ReadLine());
        double perimetro = lado * 4;
        Console.WriteLine("El perímetro del cuadrado es " + perimetro);
    }
}