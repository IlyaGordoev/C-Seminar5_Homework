// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

double[] FillArrayWithRandomNumber(int size)
{
double[] arr = new double[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.Next(0, 100) + rnd.NextDouble(), 1);  // rnd.NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
    }
    return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));

double diff = 0;
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i +=2)
{
    if (array[i] > max)
    max = array[i];
    if (array[i] < min)
    min = array[i];
}
diff = max - min;

System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {diff}");