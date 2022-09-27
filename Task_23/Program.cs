//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Zadacha23()
{
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
double cub;
while (i <= num)
{
    cub = Math.Pow(i,3);
    Console.WriteLine($"Число в кубе: {i} * {i} = {cub}");
    i++;
}
}
Zadacha23();