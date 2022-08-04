
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите пятизначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 10000 || num > 99999) {
            Console.WriteLine("Число не пятизначное");
            return;
        }

        int n5 = num % 10;
        int n4 = num / 10 % 10;
        int n2 = num / 1000 % 10;
        int n1 = num / 10000 % 10;

        Console.WriteLine(n1 == n5 && n2 == n4 ? "Палиндром" : "Не палиндром");
    }
}
 
