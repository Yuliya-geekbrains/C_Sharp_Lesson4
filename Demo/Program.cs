// Напишите программу, оторая принимает на вход число (А) и выдает сумму чисел от 1 до A.

// 7 -> 28

// 4 -> 10

// 8 -> 36

Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {limit} равна {GetSum(limit)}");

// функция подсета суммы от 1 до А

int GetSum(int A){
    int sum = 0;
    for(int i = 1; i <= A; i++){
        sum = sum + i; // sum +=i
    }
    return sum;
}