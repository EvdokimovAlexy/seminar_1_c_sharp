Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int i = -1 * number;
while (i <= number)
{
    Console.Write(i);
    i +=1;
}
