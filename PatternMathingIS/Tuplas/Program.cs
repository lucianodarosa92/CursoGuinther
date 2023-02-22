
(int, string) GetCliente()
{
    return (23, "Luciano");
}

var cliente = GetCliente();
Console.WriteLine(cliente.Item1);
Console.WriteLine(cliente.Item2);


void exemplo5()
{
    int Somar((int, int, int) tupla)
    {
        return tupla.Item1 + tupla.Item2 + tupla.Item3;
    }
    var tupla = (1, 2, 3);
    var soma = Somar(tupla);
    Console.WriteLine(soma);
}

/*
void exemplo4()
{
    var tupla = (1, 1, 1);
    Func<(int a, int b, int c), int> = tupla =>
    {
        return (tupla.a, tupla.b, tupla.c);
    }
}
*/

void Exemplo3()
{
    var tupla = (Codigo: 10, Nome: "Guinter");
    Console.WriteLine(tupla.Codigo);
    Console.WriteLine(tupla.Nome);
}

void Exemplo2()
{
    (int, string, bool) tupla = (1, "Luciano", true);
    Console.WriteLine(tupla.Item1);
    Console.WriteLine(tupla.Item2);
}

void Exemplo1()
{
    (int, string) tupla1 = (10, "Guinter");
    (bool, string) tupla2 = (true, "Ativo");
    var nome = tupla1.Item2;
    var ativo = tupla2.Item1;

    Console.WriteLine(nome);
    Console.WriteLine(ativo);
}