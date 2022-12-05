// Задача №18. Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (X и Y).

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введите номер четверти от 1 до 4");
int a = Convert.ToInt32(Console.ReadLine());

switch(a)
{
    case 1:
        Console.WriteLine("x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0, y < 0");
        break;
    default:
        Console.WriteLine("Error! Введите значение от 1 до 4!");
        break;
}