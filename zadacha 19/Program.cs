// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// Числа натуральные, автоматически генерируются из диапазона
// от 10000 до 99999.

int x = new Random().Next(10000, 99999);
int num = x;
int res = 0;
while(x > 0)
{
    int y = x % 10;
    res = res * 10 + y;
    x = x / 10;
}
if(num == res)
{
    Console.Write(num);
    Console.Write(" - это палиндром");
}
else
{
    Console.Write(num);
    Console.Write(" - это не палиндром");
}