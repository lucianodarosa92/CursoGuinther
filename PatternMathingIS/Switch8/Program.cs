//Main
Console.WriteLine(GetStatus(Status.Insert));

// função que retorna a string do enum
static string GetStatus(Status status) =>
    status switch
    {
        Status.Insert => "Inserindo...",
        Status.Update => "Atualizando...",
        Status.Delete => "Excluindo...",
        _ => "Sem estado"
    };

enum Status { Insert, Update, Delete };