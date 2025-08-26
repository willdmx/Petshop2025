public abstract class Animal
{
    private string nome;
    private int idade;

    public string Nome
    {
        get => nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Nome não pode ser vazio.");
            nome = value;
        }
    }

    public int Idade
    {
        get => idade;
        set
        {
            if (value < 0)
                throw new ArgumentException("Idade não pode ser negativa.");
            idade = value;
        }
    }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public abstract void Atender();
}