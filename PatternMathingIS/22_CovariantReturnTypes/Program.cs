
var fab = new FabricaPF();
PF p1 = fab.CriarPessoa();

p1.Nome = "Luciano";
p1.CPF = "0284848929";

Console.WriteLine(p1.Nome);
Console.WriteLine(p1.CPF);

//Factory
public abstract class FabricaPessoa
{
    public abstract Pessoa CriarPessoa();
}

public class FabricaPF: FabricaPessoa
{
    public override PF CriarPessoa()
    {
        return new PF();
    }
}
public class FabricaPJ : FabricaPessoa
{
    public override PJ CriarPessoa()
    {
        return new PJ();
    }
}


//class
public class Pessoa
{
    public string Nome { get; set; }
}
public class PF : Pessoa
{
    public string CPF { get; set; }
}

public class PJ : Pessoa
{
    public string CNPJ { get; set; }
}