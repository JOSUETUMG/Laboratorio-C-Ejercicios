//Mostrar los múltiplos de 8 hasta el valor 500. Debe aparecer en pantalla 8 - 16 - 24, etc


//Ejercicio 8 Multiplos

class Program
{
    static void Main()
    {
        for (int i = 8; i <= 500; i += 8)
        {
            Console.Write(i + " ");
        }
    }
}
