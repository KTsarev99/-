//  Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
Console.WriteLine("Введите размер масива");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string [size];
int length = 3;
int pos = 0;

for(int i = 1; i<= size;i++)
{
 Console.WriteLine($"Введите {i}-й элемент: ");
 string element = Convert.ToString(Console.ReadLine());
 if (element.Length <= length)
    {
        array[pos] = element;
        pos++;
    }
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{  
    Console.Write(array[i]+ " ");
}
