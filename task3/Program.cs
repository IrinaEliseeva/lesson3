//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
public class Program
 {
    public static void Main()
    {
        Console.WriteLine("Введите число");

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < n; i ++) {
            Console.WriteLine(i * i * i);
        }
    }
}
 
