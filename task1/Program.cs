//string name1 = "Bob";
//string name2 = "Liz";
//string name3 = "John";
//string name4 = "Ann";
//string name5 = "Sarah";

//string [] names = {"Bob", "Liz", "John", "Ann", "Sarah"};
//Console.WriteLine(names[3]);

//names[3] = "Anna";
//Console.WriteLine(names[3]);

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
// }
Console.Write($"Enter the number of elements ");
int num = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[num];
for(int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(1, 100);
}
for(int i = 0; i < nums.Length; i++)
{
    Console.Write($"{nums[i]} ");
}