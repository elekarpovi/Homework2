//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

System.Console.WriteLine("Введите цифру, обозначающую день недели: 1 - понедельник, 2 - вторник, 3 - среда, 4 - четверг, 5 - пятница, 6 - суббота, 7 - воскресенье. ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 5 && a < 8) 
{
    System.Console.WriteLine("Выходной день");
}

else if (a > 0 && a < 6) 
{
    System.Console.WriteLine("Рабочий день");
}

else
System.Console.WriteLine("Число должно быть от 1 до 7");