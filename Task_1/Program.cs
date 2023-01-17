// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА


 void FillArray(int[] collection)                                 // Метод заполнения массива случайными числами от 1 до 10
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);             //Положить случайное число от 1 до 10 в каждый элемент массива
        index++;
    }
}

void PrintArray(int[] collection)                                 // Метод печати первого массива
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{collection[position]} ");
        position++;
    }
    Console.Write(">>>");
}

int[] multiplication(int[] array)                                 // Метод вычисления парного произведения чисел с начала и конца массива
{
    int[] resultOfmultiplication = new int[array.Length / 2];

    for (int i = 0; i < array.Length / 2; i++)                
    {
        resultOfmultiplication[i] = array[i] * array[array.Length - 1 - i];
    }
    return resultOfmultiplication;

}


void PrintResult(int[] collection)                                // Метод печати массива-результата произведения
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" {collection[position]} ");
        position++;
    }
}

int[] array = new int[10];   
FillArray(array);
PrintArray(array);
int[] resultOfmultiplication = multiplication(array);
PrintResult(resultOfmultiplication);