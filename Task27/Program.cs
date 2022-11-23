// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int digitSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10;
        sum += digit;
        num = num / 10;
    }
    return sum;
}

int res1 = digitSum(452);
Console.WriteLine(res1);

int res2 = digitSum(82);
Console.WriteLine(res2);

int res3 = digitSum(9012);
Console.WriteLine(res3);
