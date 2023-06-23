// Напишите программу, которая на вход принимает число и выдает количество цифр в числе
// (т.е у нас будет прогамма, коорая принмает на иход число, а функция этой программы будет подчест количества цифр в числе)
//
//

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе {number} составляет {quantity(number)}.");

int quantity(int A)
{
    int count = 0;
    while(A > 0)
    {
        count++;
        A = A / 10; // number /= 10
    }
    return count;
}    
    
