//Realizar un programa que acumule (sume) valores ingresados por teclado 
//hasta ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). 
//Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.


//Ejercicio 9 Valor acumulado 

class Program
{
    static void Main()
    {
        int acumulado = 0;
        int valor;

        do
        {
            Console.Write("Ingrese un valor (9999 para finalizar) ");
            valor = Convert.ToInt32(Console.ReadLine());

            if (valor != 9999)
            {
                acumulado += valor;
            }

        } while (valor != 9999);

        Console.WriteLine("Valor acumulado " + acumulado);

        if (acumulado > 0)
            Console.WriteLine("El valor acumulado es mayor a cero.");
        else if (acumulado < 0)
            Console.WriteLine("El valor acumulado es menor a cero.");
        else
            Console.WriteLine("El valor acumulado es cero.");
    }
}