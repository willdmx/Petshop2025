public class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade) { }

    public override void Atender()
    {
        Console.WriteLine($"{Nome} está sendo atendido. 🐈 Ele mia: Miau!");
    }
}