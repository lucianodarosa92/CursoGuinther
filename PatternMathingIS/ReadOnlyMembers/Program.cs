//Main
var p1 = new Pessoa() { Nome = "Luciano", Altura = 1.89, Peso = 100 };
// Console.WriteLine($"{p1.Nome}, seu IMC é {p1.IMC()}");
Console.WriteLine(p1);

//Classes
public struct Pessoa
{
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public readonly double IMC() => Peso / (Altura * 2);
    public readonly override string ToString() => $"{Nome}, seu IMC é {IMC()}";
}