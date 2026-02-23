namespace Verificador_de_Idade;

public class Program
{
	public static void Main()
	{
		Person person = new Person();

		Console.WriteLine("Digite uma idade: ");

		try
		{
			int Age = Convert.ToInt32(Console.ReadLine());

			string response = person.IfLegalPersonRefactor(Age);
			Console.WriteLine(response);
		}
		catch
		{
			Console.WriteLine("Valor inválido. Digite um valor válido.");
		}
	}
}
