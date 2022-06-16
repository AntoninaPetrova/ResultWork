/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 

Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/ 

System.Console.WriteLine("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());

string[] array = new string[M];
int index = 0;
while (index < M)
{
    System.Console.WriteLine("Введите строку: ");
    string word = Convert.ToString(Console.ReadLine());
    array[index] = word;
    index++;
}

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "   ");
    }
    System.Console.WriteLine();
}
string[] array2 = new string[M];

void FinalArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}

System.Console.WriteLine("Первоначальный массив: ");
Print(array);
FinalArray(array, array2);
System.Console.WriteLine("Итоговый массив: ");
Print(array2);