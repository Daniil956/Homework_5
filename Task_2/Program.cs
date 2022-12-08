// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    if(i%2 == 1)
    {
        sum += arrey[i];
    }
}

Console.WriteLine("[" + string.Join(", ", arrey) + "] -> " + sum);