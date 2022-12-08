// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] arrey = new int[4];
int LEFTRABGE = 100;
int RAGTHRANGR = 1000;

int[] FillArrey(int leftRange, int rigthRange)
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

for (int i = 0; i < arrey.Length; i++)
{
    if (i % 2 == 1)
    {
        int max = 0;
        if (arrey[i] > max)
        {
            sum += arrey[i];
        }
    }
}

Console.WriteLine("[" + string.Join(", ", arrey) + "] -> " + sum);