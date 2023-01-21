//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

System.Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());

 
if (Math.Abs(a) > 99)  
{
        while  (Math.Abs(a) > 999) 
        { 
        a  = a / 10;
        }
    a = Math.Abs(a % 10);
    System.Console.WriteLine($"Третья цифра числа: {a}");  
}

else

    System.Console.WriteLine($"Третьей цифры нет!");
  
//string? str = Console.ReadLine(); Вариант решения
//if (str == null) return;
//System.Console.WriteLine(str[2]);