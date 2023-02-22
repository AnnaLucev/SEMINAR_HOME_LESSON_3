//
// Упорядочить массив от максимального значения к минимальному(через мин и макс)
//  68321457  ---- 87654321
// 1. Найти позицию максимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением 1*й неотсортированной позиции
// 3. Повторять пока есть неотсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 8, 1}; // задаем массив

void printArray (int[] array)   // метод вывода на экран массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

//  printArray (arr); // запуск метода

void selectionSortMaxMin (int[] array)  // метод сортировки от макс к мин
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition])
                minPosition = j;
        } 
        int temporary = array[i];  // временный элемент
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
selectionSortMaxMin (arr);
printArray (arr);