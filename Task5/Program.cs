Console.Write("Ввдите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = -number;
while (a <= number) 
{
    Console.Write(a + ",");  
    a++;
    
}