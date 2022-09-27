//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Zadacha19()
{
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int curent_num = num;
int res = 0;
while (curent_num > 0)
{
    int numeral = curent_num % 10;
    res = res * 10 + numeral;
    curent_num /=10;
    Console.WriteLine(res);  
}
if (num == res)
{
    Console.WriteLine($"Число {num}: является палиндромом");
}
else
{
    Console.WriteLine($"Число {num}: не является палиндромом");
}
}
Zadacha19();
