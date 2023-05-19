using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace UdemyNovo1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string produto1 = "Computador";
			string produto2 = "Mesa de escritório";
			string nome = "Willian Florencio Calixto";
			string nome_de_registro_da_nota = "Produto de ";


			byte idade = 21;
			int código = 5290;
			char genero = 'M';

			

			double preco1 = 2100.0;
			double preco2 = 650.50;
			double medida = 53.234567;

			double total = preco1 + preco2;

			Console.WriteLine("===================================================================================");
			Console.WriteLine("  ");
			Console.WriteLine(  "           "  + nome_de_registro_da_nota + nome + "            ");
			Console.WriteLine("===================================================================================");
			Console.WriteLine("Registro: " + nome + ", tem " + idade + " anos de idade, código " + código + ", gênero: " + genero);
			Console.WriteLine("  ");
			Console.WriteLine("  ");
			Console.WriteLine("===================================================================================");
			Console.WriteLine("Produtos");
			Console.WriteLine(produto1 + " Cujo o preço é: R$" + preco1.ToString("F2"));
            Console.WriteLine(produto2 + "cujo o preço é: R$" + preco2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("===================================================================================");
            Console.WriteLine("  ");
			Console.WriteLine("  ");

			Console.WriteLine("         Medida da mesa          ");
			Console.WriteLine("Medida:" + medida.ToString("F8"));
			Console.WriteLine("Medida com três casas decimais:" + medida.ToString("F3"));

			Console.WriteLine(("Medida com três casas decimais, e com o ponto separando a casa decimal: " + medida.ToString("F3", CultureInfo.InvariantCulture)));
			Console.WriteLine("  ");
			Console.WriteLine("  ");

			Console.WriteLine("Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));

		}
	}
}
