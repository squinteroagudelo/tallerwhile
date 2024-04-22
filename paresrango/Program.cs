namespace paresrango;

internal class Program
{
	// Escriba un programa que solicite dos numeros, uno que indica el inicio y el otro indica el final.
	public static void Main(string[] args)
	{
		int num1, num2;
           
		Console.Write("Ingrese el número inicial del rango: ");
		num1 = int.Parse(Console.ReadLine());
		Console.Write("Ingrese el número final del rango: ");
		num2 = int.Parse(Console.ReadLine());

		if (num1 > num2)
		{
			Console.WriteLine("El número final no puede ser menor al inicial, intercambiaremos los valores entre sí");
			(num1, num2) = (num2, num1);
		}
		
		Console.WriteLine($"Los número pares entre {num1} y {num2} son:");

		do
		{
			num1++;
			if (num1 == num2)
			{
				break;
			}

			if(num1 % 2 == 0)
			{
				Console.WriteLine(num1);
			}
		} while (num1 <= num2);

		/*while (num1 <= num2) 
		{
			if(num1 % 2 == 0)
			{
				Console.WriteLine(num1);
			}
			num1++;
		}*/

		Console.ReadKey();
	}
}