//main
var aluno = new Aluno() { Matricula = 123, Nome = "Luciano" };
// aluno.Matricula = 2444; //não pode alterar depois da construção

// Classes (DTO / POCO)
public class Aluno
{
    public int Matricula { get; init; }
    public string Nome { get; set;  }
}