Console.WriteLine ("Введите целое число: ");
int number = int.Parse (Console.ReadLine()!);
for (int N=2; N<=number; N=N+2)
{   
        Console.Write (N + " ");
}