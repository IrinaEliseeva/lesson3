//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
public class Program
 {
    public static int ReadInt() 
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void Main()
    {
        Console.WriteLine("Введите координаты первой точки - 3 числа:");
        int x1 = ReadInt();
        int y1 = ReadInt();
        int z1 = ReadInt();
        
        Console.WriteLine("Введите координаты второй точки - 3 числа:");
        int x2 = ReadInt();
        int y2 = ReadInt();
        int z2 = ReadInt();

        int dx = x2 - x1;
        int dy = y2 - y1;
        int dz = z2 - z1;
        
        int len = (int)System.Math.Round(System.Math.Sqrt(dx * dx + dy * dy + dz * dz));

        Console.WriteLine("Расстояние: {0:D}", len);
    }
}
 
