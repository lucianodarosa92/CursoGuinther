//Main
string Pessoa = "Teste1";
GetPessoa(out Pessoa);
Console.WriteLine(Pessoa);

static void GetPessoa(out string Nome)
{
    Nome = "Teste2";
}