public class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade) { }

    public override void Atender()
    {
        Console.WriteLine($"{Nome} está sendo atendido. 🐕 Ele late: Au au!");
    }
}