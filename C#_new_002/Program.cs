// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int a=int.Parse (Console.ReadLine ()!);
Console.WriteLine("Введите второе число: ");
int b= int.Parse (Console.ReadLine ()!);
Console.WriteLine("Введите третье число: ");
int c= int.Parse (Console.ReadLine ()!);
int max;
max = a;
if (b > max)
{max=b;}
if (c > max)
{max = c;}
Console.WriteLine ("Max number: " + max);