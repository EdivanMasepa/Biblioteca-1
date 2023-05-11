using System;
using System.Collections.Generic;

namespace Biblioteca
{
	class Program 
	{
		static void Main (string[] args)
		{
			// Instancia o objeto biblioteca (lógica do negócio)
			Biblioteca biblioteca = new Biblioteca();			
			biblioteca.CarregarDados();

			int opcao;			
			do
			{
				Console.Clear();
				Console.WriteLine("-- Bem vindo à Biblioteca --");
				Console.WriteLine("Selecione uma opção:");
				Console.WriteLine("1 - Cadastro");
				Console.WriteLine("2 - Consulta");
				Console.WriteLine("3 - Empréstimos");
				Console.WriteLine("4 - Devoluções");
				Console.WriteLine("0 - Sair");
				
				int.TryParse(Console.ReadLine(), out opcao);
				
				switch (opcao)
				{
					case 1:
						Cadastro(biblioteca);
						break;
					case 2:
						Consulta(biblioteca);
						break;
					case 3:
						Emprestimo(biblioteca);
						break;
					case 4:
						Devolucoes(biblioteca);
						break;
					case 0:
						Console.WriteLine("Encerrando o sistema...");
						Console.ReadKey();
						break;	
				}
				
			} while (opcao != 0);										
		}
		
		static void Cadastro(Biblioteca biblioteca)
		{
			Console.Clear();
			Console.WriteLine("Selecione uma opção de cadastro:");
			Console.WriteLine("1 - Cadastrar cliente");
			Console.WriteLine("2 - Cadastrar livro");
			Console.WriteLine("0 - Voltar");

			int.TryParse(Console.ReadLine(), out int opcao);

			switch (opcao){
				case 1:
					Console.Clear();
					Console.WriteLine("Cadastro de cliente: ");
					Console.Write("Nome: ");
					string nomeCliente = Console.ReadLine();
					Console.WriteLine("Data de nascimento (AAAA-MM-DD): ");
					DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);
					Console.WriteLine("Telefone: ");
					string telefone = Console.ReadLine();

					Cliente novoCliente = new Cliente{Id = biblioteca.clientes.Count + 1, Nome = nomeCliente, DataNascimento = dataNascimento, Telefone = telefone};
					biblioteca.clientes.Add(novoCliente);
					biblioteca.SalvarDados();
					Console.WriteLine("Cliente cadastrado com sucesso!");
					Console.ReadKey();
				break;
				case 2:
					Console.Clear();
					Console.WriteLine("Cadastro de livro: ");
					Console.WriteLine("Titulo: ");
					string titulo = Console.ReadLine();
					Console.WriteLine("Autor: ");
					string autor = Console.ReadLine();

					Livro novolivro = new Livro{Id = biblioteca.livros.Count + 1, Titulo = titulo, Autor = autor, Disponivel = true};
					biblioteca.livros.Add(novolivro);
					biblioteca.SalvarDados();
					Console.WriteLine("Livro cadastrado com sucesso!");
					Console.ReadKey();	
				break;	
			}
		}
		
		static void Consulta(Biblioteca biblioteca)
		{
			
		}
		
		static void Emprestimo(Biblioteca biblioteca)
		{
			
		}
		
		static void Devolucoes(Biblioteca biblioteca)
		{
			
		}
	}
	
}
