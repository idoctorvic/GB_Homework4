// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Запуск программы с готовыми данными
int InPower(int baseNum, int powNum)
{
    int result = 1;
    for (int i = 1; i <= powNum; i++)
    {
        result *= baseNum;
    }
    
    return result;
}

var res = InPower(3, 5);
Console.WriteLine(res);

var res1 = InPower(2, 4);
Console.WriteLine(res1);

// Запуск программы с введением данных с консоли
// int InPower()
// {
//     Console.Write("Enter the first number: ");
//     int baseNum = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter the second number: ");
//     int powNum = Convert.ToInt32(Console.ReadLine());
//     int result = 1;
//     for (int i = 1; i <= powNum; i++)
//     {
//         result *= baseNum;
//     }
    
//     return result;
// }

// var res = InPower();
// Console.WriteLine(res);

