//Main
var Numero1 = new Numeros() { X = 10, Y = 10 };
Testar(Numero1);

Console.WriteLine(Numero1.X);
Console.WriteLine(Numero1.Y);

void Testar(Numeros numeros)
{
    numeros.X = 20;
    numeros.Y = 20;
}

public class Numeros
{
    public int X { get; set; }
    public int Y { get; set; }
}