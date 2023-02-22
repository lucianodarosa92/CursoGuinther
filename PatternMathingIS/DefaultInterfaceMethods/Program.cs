//Main
ILog log = new TxtLog();
log.Log("OK...");

//Classes
public interface ILog
{
    void Log(string message)
    {
        Console.WriteLine($"base: {message}");
    }
}
public class TxtLog: ILog
{
    public void Log(string message)
    {
        File.WriteAllText("log.txt", message);
    }
}