

using System.Text;

FileStream arq = new FileStream("log.txt", FileMode.Create);
try
{
    // exportar
}
finally
{
    arq.Dispose();
}


using (var arq2 = new FileStream("log.txt", FileMode.Create))
{
    // exportar
    byte[] bytess = Encoding.UTF8.GetBytes("Teste");
    arq2.Write(bytess, 0, bytess.Length);
}

using FileStream arq3 = new FileStream("log.txt", FileMode.Create);
byte[] bytes = Encoding.UTF8.GetBytes("Teste");
arq3.Write(bytes, 0, bytes.Length);
//dispose
