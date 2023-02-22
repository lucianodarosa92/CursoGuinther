Pessoa p1 = new PF() { Nome = "Luciano", CPF = "02751148050", Salario = 200.34 };
Pessoa p2 = new PJ() { Nome = "Appelsoft", CNPJ = "111221121212121312121212", Faturamento = 543.76 };


MostrarPessoa(p1);
MostrarPessoa(p2);

void MostrarPessoa(Pessoa pessoa)
{
    switch (pessoa)
    {
        case PF pf when (pf.Salario > 0.0) && (pf.CPF.Length > 0.0):
            {
                Console.WriteLine(pf.CPF);
                break;
            }
        case PJ pj when pj.Faturamento > 0:
            {
                Console.WriteLine(pj.CNPJ);
                break;
            }
    }
}


public class Pessoa
{
    public string Nome { get; set; }
}
public class PF : Pessoa
{
    public string CPF { get; set; }
    public double Salario { get; set; }
}

public class PJ : Pessoa
{
    public string CNPJ { get; set; }
    public double Faturamento { get; set; }
}