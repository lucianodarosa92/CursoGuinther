// Main
double Salario = 2000;
double Imposto = CalcularImposto(Salario);
Console.WriteLine($"Imposto a pagar: {Imposto}");
    
double CalcularImposto(in double Salario)
{
    if (Salario > 2_286.650)
        return Salario * 0.15;
    if (Salario > 1_903.00)
        return Salario * 0.075;
    return 0;
}