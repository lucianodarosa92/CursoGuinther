//Main
Cliente cli = new Cliente { Codigo = 10, Nome = "Luciano" };

// Pattern matching - Property
if (cli is { Codigo: 10 })
    Console.Write("é o cliente 10");

// Pattern matching - const
if (cli.Nome is "Luciano")
    Console.Write("é o cliente Luciano");

//Classes
public class Cliente
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
}