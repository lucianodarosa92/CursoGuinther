//main
var cli = new Cliente() 
{ 
    Codigo = 123, 
    Nome = "Guinter", 
    Telefone = "99999" 
};
// cli.Nome = "teste";

public record Cliente
{
    public int Codigo { get; init; }
    public string Nome { get; init; }
    public string Telefone { get; init; }
}