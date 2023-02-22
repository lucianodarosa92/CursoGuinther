var a = new Aluno(1938, "Luciano");
Console.WriteLine(a);

public struct Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public Aluno()
    {
        Matricula = 0;
        Nome = "Default";
    }
    public Aluno(int matricula, string nome, bool flag)
    {
        Matricula = matricula;
        Nome = nome;
    }
    public Aluno(int matricula, string nome) => (Matricula, Nome) = (matricula, nome);
    public override string ToString() => $"{Matricula} - {Nome}";
}