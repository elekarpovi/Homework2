//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

System.Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a<1000) && (a>99) || (a<-99) && (a>-1000))
{
    int firstTwoNumbers = a / 10;
    int secondNumber = firstTwoNumbers % 10;
    System.Console.WriteLine($"Вторая цифра числа: {Math.Abs(secondNumber)}");
}

else
{
    System.Console.WriteLine($"Ошибка, введите трехзначное число!");
}
