//вычисление расстояния между точками в трехмерном пространстве

int InputIn(string message)
{
    System.Console.Write(($"{message} = "));
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    if (isCorrect)
    {
        return value;
    }
    System.Console.WriteLine("You entered not a number");
    Environment.Exit(-1);
    return 0;
}

double distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int DeltaX = x2-x1;
    int DeltaY = y2-y1;
    int DeltaZ = z2-z1;
    return Math.Sqrt(DeltaX*DeltaX+DeltaY*DeltaY+DeltaZ*DeltaZ);
}

System.Console.WriteLine("Enter point A");
int x1 = InputIn("x1");
int y1 = InputIn("y1");
int z1 = InputIn("z1");
System.Console.WriteLine("Enter point B");
int x2 = InputIn("y2");
int y2 = InputIn("x2");
int z2 = InputIn("z2");

string pointA = ($"Point A({x1},{y2},{z1})");
string pointB = ($"Point B({x2},{y2},{z2})");
double distanceAB = distance3D(x1,y1, z1, x2,y2, z2);

System.Console.WriteLine($"Distance between {pointA} and {pointB}: AB = {distanceAB}");

