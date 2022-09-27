// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Zadacha21()
{
    Console.Clear();
    Console.Write("Введите координаты первого число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координаты второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int a_x = a;
    int a_y = a;
    int a_z = a;
    int b_x = b;
    int b_y = b;
    int b_z = b;
    double res = Math.Sqrt(Math.Pow(a_x - b_x, 2) + Math.Pow(a_y - b_y, 2) + Math.Pow(a_z - b_z, 2));
    {
         Console.WriteLine(res);
    }  
}
Zadacha21();