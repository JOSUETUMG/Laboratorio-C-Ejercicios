//Escribir un programa que pida ingresar la coordenada de un punto en el plano, 
//es decir dos valores enteros x e y (distintos a cero). Posteriormente imprimir 
//en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 
//2º Cuadrante: x < 0 Y y > 0, etc.)

//Ejercicio 5 Cuadrantes

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la coordenada X ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la coordenada Y ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
            Console.WriteLine("El punto está en el primer cuadrante ");
        else if (x < 0 && y > 0)
            Console.WriteLine("El punto está en el segundo cuadrante ");
        else if (x < 0 && y < 0)
            Console.WriteLine("El punto está en el tercer cuadrante ");
        else if (x > 0 && y < 0)
            Console.WriteLine("El punto está en el cuarto cuadrante ");
    }
}