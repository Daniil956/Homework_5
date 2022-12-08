// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] arrey = new int[10];
int LEFTRABGE = 100;
int RAGTHRANGR = 1000;

int[] FillArrey(int leftRange,  int rigthRange)
{
    Random rand = new Random();
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = rand.Next(LEFTRABGE, RAGTHRANGR);
    }
    return arrey;
}

arrey = FillArrey(LEFTRABGE, RAGTHRANGR);
int sum = 0;

for(int i = 0; i < arrey.Length; i++)
{
    if(arrey[i]%2 == 0)
    {
        sum+=1;
    }
}

Console.WriteLine("[" + string.Join(", ", arrey) + "] -> " + sum);