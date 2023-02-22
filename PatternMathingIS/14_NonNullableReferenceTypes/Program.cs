//Main
string StrNaoNula = "Helo";
string? StrAnulavel = default;
StrNaoNula = StrAnulavel!;
Console.WriteLine(StrNaoNula.ToUpper());

//Main
// string? Nome = null;
// Console.WriteLine(Nome?.ToUpper());