//Main
var alunos = new[] { "Luciano", "José", "Arnaldo" };
ref string aluno = ref alunos[1];
aluno = "TESTE";
Console.WriteLine(string.Join(" ", alunos));

//Método usando reference return
static ref string GetAluno(string[] nomes, int index)
{
    return ref nomes[index];
}