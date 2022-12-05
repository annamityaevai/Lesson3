// Задача №17. Напишите программу, которая принимает на вход координаты
// точки (X и Y), причем X != 0 и Y != 0 и выдает номер четверти плоскости,
// в которой находится эта точка

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Ввести значение оси X, не равное 0");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести значение оси Y, не равное 0");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}