namespace contadorpaso;

internal class Program
{
	public static void Main(string[] args)
	{
		int num = 0, cont, cont2;
		Console.Write("Ingrese hasta el número que desea contar: ");
		cont = int.Parse(Console.ReadLine());

		if (cont > 0)
		{
			Console.Write("Indique de cuanto en cuanto quiere contar? ");
			cont2 = int.Parse(Console.ReadLine());
			num = cont2;

			while (num <= cont)
			{
				Console.WriteLine(num);
				num = num + cont2;
			}
		}
		else
		{
			Console.WriteLine("Cantidad no válida");
		}

		Console.ReadKey();
	}
}

