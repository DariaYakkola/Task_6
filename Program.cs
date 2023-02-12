Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers % 2 == 0 )
{
  Console.WriteLine(numbers + " - четное число");
}
else
{
  Console.WriteLine(numbers + " - нечетное число");
}