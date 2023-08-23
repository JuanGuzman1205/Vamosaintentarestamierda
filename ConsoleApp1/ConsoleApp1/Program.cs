/*Realizar un algoritmo que me pida 3 numeros por pantalla, con el primero hallar el cuadrado, con el segundo hallar la raiz 
 * y con el tercero hallar la raiz cubica. Mostrar en pantalla los 3 resultados*/   
public class TresVariables
{
    static void Main(string[] args)
    {
        int num1, num2,num3, potencia, raizcuadrada, raizcubica;

        Console.Write("Ingrese su primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese su segundo número; ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese su tercer número: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        potencia = num1 * num1;
        raizcuadrada = (int)Math.Sqrt(num2);
        raizcubica = (int)Math.Cbrt(num3);

        Console.Write("El cuadrado es:" + potencia);
        Console.Write("\n");
        Console.Write("La Raiz cuadrada es: " + raizcuadrada);
        Console.Write("\n");
        Console.Write("La raiz cubica es: " + raizcubica);
       
        
    }




}
