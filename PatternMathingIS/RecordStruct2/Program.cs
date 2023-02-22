
var p1 = new Point(10, 20);
var p2 = p1;

Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p2.GetHashCode());

public readonly record struct Point(int X, int Y);