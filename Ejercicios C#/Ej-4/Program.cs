//Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información: 
//cantidad total de preguntas que se le realizaron y la cantidad de preguntas que contestó correctamente. 
//Se pide confeccionar un programa que ingrese los dos datos por teclado e informe el nivel del mismo 
//según el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:
//	Nivel máximo:	Porcentaje>=90%.
//	Nivel medio:	Porcentaje>=75% y <90%.
//	Nivel regular:	Porcentaje>=50% y <75%.
//	Fuera de nivel:	Porcentaje<50%.

// Ejercicio 4 Porcentajes

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad total de preguntas ");
        int totalPreguntas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la cantidad de preguntas correctas ");
        int correctas = Convert.ToInt32(Console.ReadLine());

        double porcentaje = (double)correctas / totalPreguntas * 100;

        if (porcentaje >= 90)
            Console.WriteLine("Nivel máximo");
        else if (porcentaje >= 75)
            Console.WriteLine("Nivel medio");
        else if (porcentaje >= 50)
            Console.WriteLine("Nivel regular");
        else
            Console.WriteLine("Fuera de nivel");
    }
}