Console.Write("Ввдите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввдите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberB / numberA;
if (result == numberA)
{
    Console.WriteLine("Да ");
}
else 
{
    Console.WriteLine("Нет");
}