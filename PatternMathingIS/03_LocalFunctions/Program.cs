
Pessoa p2 = new Pessoa() { Nome = "Luciano", Altura = 1.75, Peso = 72.5 };

p2.MostrarIMC();

public class Pessoa
{
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }

    public void MostrarIMC()
    {
        double CalcularIMC()
        {
            return Peso / (Altura * 2);
        }

        Console.WriteLine($"{Nome} seu IMC é {CalcularIMC()}");
    }


}