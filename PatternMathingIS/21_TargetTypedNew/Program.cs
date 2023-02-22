
Cliente cli = new () { Codigo = 123, Nome = "Luciano" };
MostrarCliente(cli);

MostrarCliente(new() { Codigo = 123, Nome = "Luciano" });

void MostrarCliente(Cliente cli)
{
    Console.WriteLine(cli.Nome);

}
public record Cliente
{
    public int Codigo { get; init; }
    public string Nome { get; init; }
    public string Telefone { get; init; }
}