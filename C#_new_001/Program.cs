// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int a=int.Parse (Console.ReadLine ()!);
Console.WriteLine("Введите второе число: ");
int b= int.Parse (Console.ReadLine ()!);
int max,min;
if (a!=b)
    {if (a>b) 
        {max =a;
        min=b;
        Console.WriteLine ("Max = "+ max);
        Console.WriteLine ("Min = "+ min);
        }
    else
        {max=b;
        min=a;
        Console.WriteLine ("Max = "+ max);
        Console.WriteLine ("Min = "+ min);
        }
}         
else 
{Console.WriteLine ("Числа равны");
} 