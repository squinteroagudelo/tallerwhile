namespace contador;

internal class Program
{
	// Escriba un programa que cuente hasta el número que quiera el usuario.
	public static void Main(string[] args)
	{
		int num = 1, cont;
		Console.Write("Ingrese hasta el número que desea contar: ");
		cont = int.Parse(Console.ReadLine());

		if (cont > 0)
		{
			while (num <= cont)
			{
				Console.WriteLine(num);
				num++;
			}
			
		}
		else
		{
			Console.WriteLine("Cantidad no válida");
		}
		Console.ReadKey();
	}
}