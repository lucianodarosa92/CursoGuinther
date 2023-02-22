Pessoa p1 = new PF() { Nome = "Luciano", CPF = "02751148050" };
Pessoa p2 = new PJ() { Nome = "João", CNPJ = "111221121212121312121212" };


MostrarPessoa(p1);
MostrarPessoa(p2);

void MostrarPessoa (Pessoa pessoa)
{
    Console.WriteLine(pessoa.Nome);
    if (pessoa is PF pf)
        Console.WriteLine(pf.CPF);
    else if (pessoa is PJ pj)
        Console.WriteLine(pj.CNPJ);
}


public class Pessoa
{
    public string Nome { get; set; }
}
public class PF: Pessoa 
{ 
    public string CPF { get; set; }
}

public class PJ : Pessoa
{
    public string CNPJ { get; set; }
}