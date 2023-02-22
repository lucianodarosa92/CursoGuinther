//main
var aluno1 = new Aluno(123, "Luciano");

//clonar
var aluno2 = aluno1 with { Nome = "Rudolfo" };

Console.WriteLine(aluno2.Nome);
Console.WriteLine(aluno2.Matricula);

// declaração do record
public record Aluno(int Matricula, string Nome);