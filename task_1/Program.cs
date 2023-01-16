/* Задача 2: Напишите программу, которая на вход принимает
  два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.WriteLine("Введите первое число:");
string numberStr = Console.ReadLine();
int a = Convert.ToInt32(numberStr);

Console.WriteLine("Введите второе число:");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);
{
if (a > b);
    Console.WriteLine($"число {b} больше");
}
{
if (a < b);
    Console.WriteLine($"число {a} меньше");
}    