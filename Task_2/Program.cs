// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до {limit} равно {ProductNum(limit)}");


int ProductNum(int N){
    int Product = 1;
    for(int i = 2; i <= N; i++){
    Product = Product * i;
    }
    return Product;
}

