using System;
using System.Collections.Generic;

class Program
{
    static List<Animal> animais = new List<Animal>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Menu PetShop ---");
            Console.WriteLine("1. Cadastrar Animal");
            Console.WriteLine("2. Listar Animais");
            Console.WriteLine("3. Chamar Animal para Atendimento");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": CadastrarAnimal(); break;
                case "2": ListarAnimais(); break;
                case "3": AtenderAnimal(); break;
                case "4": return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    static void CadastrarAnimal()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        if (!int.TryParse(Console.ReadLine(), out int idade))
        {
            Console.WriteLine("Idade inválida.");
            return;
        }

        Console.Write("Espécie (cachorro/gato): ");
        string especie = Console.ReadLine().ToLower();

        try
        {
            Animal animal = especie switch
            {
                "cachorro" => new Cachorro(nome, idade),
                "gato" => new Gato(nome, idade),
                _ => throw new Exception("Espécie inválida.")
            };

            animais.Add(animal);
            Console.WriteLine("Animal cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void ListarAnimais()
    {
        if (animais.Count == 0)
        {
            Console.WriteLine("Nenhum animal cadastrado.");
            return;
        }

        for (int i = 0; i < animais.Count; i++)
        {
            Console.WriteLine($"{i}. {animais[i].Nome} ({animais[i].GetType().Name}) - {animais[i].Idade} anos");
        }
    }

    static void AtenderAnimal()
    {
        Console.Write("Digite o índice do animal: ");
        if (!int.TryParse(Console.ReadLine(), out int indice) || indice < 0 || indice >= animais.Count)
        {
            Console.WriteLine("Índice inválido.");
            return;
        }

        animais[indice].Atender();
    }
}