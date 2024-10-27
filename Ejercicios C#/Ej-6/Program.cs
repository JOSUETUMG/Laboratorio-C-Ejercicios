/Se pide confeccionar un programa que lea los datos de entrada e informe:
//A) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, 
//otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
//B) Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
//C) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.


//Ejercicio 6 Sueldo

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el sueldo del Empleado ");
        double sueldo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese los años de antigüedad ");
        int antiguedad = Convert.ToInt32(Console.ReadLine());

        if (sueldo < 500 && antiguedad >= 10)
        {
            sueldo = sueldo * 1.2;
            Console.WriteLine("Se otorga un aumento del 20%. Sueldo " + sueldo);
        }
        else if (sueldo < 500 && antiguedad < 10)
        {
            sueldo = sueldo * 1.05;
            Console.WriteLine("Se otorga un aumento del 5%. Sueldo " + sueldo);
        }
        else
        {
            Console.WriteLine("El sueldo a pagar es " + sueldo);
        }
    }
}
