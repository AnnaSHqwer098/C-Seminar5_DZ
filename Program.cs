//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] array = GetArray(12, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел в массиве = {GetCountCHetnoe(array)}");



//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] array = GetArray(10, -10, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {SumNEchetPosition(array)}");



//Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int[] array = GetArray(10, -50, 50);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {FindDiffMinMax(array)}");























int[] GetArray (int size, int minValue, int maxValue){                           //             МЕТОД
    int[] arr = new int[size];
    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

int GetCountCHetnoe (int[] arr){                                                 //             МЕТОД
    int count = 0;
    foreach (int num in arr){
        if (num % 2 == 0){
        count++;
        }
    }
    return count;
}

int SumNEchetPosition (int[] arr){                                               //             МЕТОД
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2){
        sum += arr[i]; 
    }
    return sum;
}


int FindDiffMinMax (int[] arr){                                                 //              МЕТОД
    int minArr = arr[0];
    int maxArr = arr[1];
    int diff = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] < minArr) minArr = arr[i];
        if (arr[i] > maxArr) maxArr = arr[i];
        diff = maxArr - minArr;
    }
    return diff;
}




