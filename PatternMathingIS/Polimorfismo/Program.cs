//Main
var Arquivos = new List<Arquivo>();
Arquivos.Add(new DocumentoXML() { Nome = "doc.xml" });
Arquivos.Add(new DocumentoTXT() { Nome = "arq.txt" });
Arquivos.Add(new DocumentoJSON() { Nome = "arq.json" });
Arquivos.Add(new DocumentoPDF() { Nome = "arq.pdf" });

foreach (var arquivo in Arquivos)
{
    Console.WriteLine($"Arquivo: {arquivo.Nome}");
    arquivo.Exportar();
}
    
public interface IArquivo
{

}

public abstract class Arquivo
{
    public string Nome { get; set; }
    public abstract void Exportar();
}

public class DocumentoXML : Arquivo
{
    public override void Exportar()
    {
        Console.WriteLine("Exportando para XML... <...>");
    }
}

public class DocumentoTXT : Arquivo
{
    public override void Exportar()
    {
        Console.WriteLine("Exportando para TXT... <...>");
    }
}
public class DocumentoJSON : Arquivo
{
    public override void Exportar()
    {
        Console.WriteLine("Exportando para JSON... <...>");
    }
}
public class DocumentoPDF : Arquivo
{
    public override void Exportar()
    {
        Console.WriteLine("Exportando para PDF... <...>");
    }
}