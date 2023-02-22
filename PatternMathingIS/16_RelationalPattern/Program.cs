
string Nome = "Luciano";
int Nota = 7;

string msg = $@"{Nome}, sua nota é {Nota} e você está
{
    Nota switch
    {
        > 10 => "Nota Inválida",
        >= 7 => "Aprovado",
        >= 4 => "Exame",
        >= 0 => "Reprovado",
        _ => "Nota Inválida"
    }
}";
Console.WriteLine(msg);


void exemplo02()
{
    Console.WriteLine("Digite Nota: ");
    var nota = Convert.ToInt32(Console.ReadLine());

    var msg = nota switch
    {
        > 10 => "Nota Inválida",
        >= 7 => "Aprovado",
        >= 4 => "Exame",
        >= 0 => "Reprovado",
        _ => "Nota Inválida"
    };
    Console.WriteLine(msg);
}



void Exemplo01()
{
    Console.WriteLine("Digite Nota: ");
    var nota = Convert.ToInt32(Console.ReadLine());

    var msg = nota switch
    {
        <= 0 => "Não pode ser negativo",
        > 0 and < 4 => "Reprovado",
        >= 4 and < 7 => "Exame",
        >= 7 and <= 10 => "Aprovado",
        _ => "Não pode ser maior que 10"
    };
}