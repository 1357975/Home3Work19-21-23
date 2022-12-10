void Zadacha19()
{
    Console.WriteLine("Введите 5-значное число: ");
    string number = Console.ReadLine();

    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Число:  {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число:  {number} не является палиндромом");
    }
}
Zadacha19();


void Zadacha21()
{
    //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D
    // пространстве. A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53

    Random rand = new Random();
    int x1 = rand.Next(-10, 11);
    int y1 = rand.Next(-10, 11);
    int c1 = rand.Next(-10, 11);
    int x2 = rand.Next(-10, 11);
    int y2 = rand.Next(-10, 11);
    int c2 = rand.Next(-10, 11);

    // для проверки

    //x1=3;
    //y1=6;
    //c1=8;
    //x2=2;
    //y2=1;
    //c2=-7;

    Console.WriteLine($"A ({x1}; {y1}; {c1}) B ({x2}; {y2}; {c2})");

    double Dist = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(c1 - c2, 2)), 2);

    Console.WriteLine($"Расстояние между точками A и B = {Dist}");

}
//Zadacha21();

void Zadacha23()
{
    //На входе число N - на выходе таблица кубов от 1 до N.

    Random rand = new Random();
    int N = rand.Next(1, 100);
    Console.WriteLine($"N = {N}");
    Console.WriteLine($"Таблица кубов от 1 до {N}: ");

    int i = 1;
    double result;

    while (i <= N)
    {
        result = Math.Pow(i, 3);
        Console.Write(result + " ");
        i++;
    }

}
//Zadacha23();