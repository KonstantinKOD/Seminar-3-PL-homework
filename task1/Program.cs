// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число: ");
string num=Console.ReadLine();
int len=num.Length;

if(len==5)
{
    if(num[0]==num[4]&&num[1]==num[3])
    {
        System.Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        System.Console.WriteLine($"{num} - нифига не Палиндром");
    }
}
else
{
    System.Console.WriteLine($"Требуется пятизначное число, давай по новой");
}