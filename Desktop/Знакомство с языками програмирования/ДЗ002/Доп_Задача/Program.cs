﻿// Задана последовательность натуральных чисел, завершающаяся числом 0. 
///Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, 
//который будет наибольшим, eсли из последовательности удалить наибольший элемент.

//Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих
//значения 100. Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0,
//перед которым идет как минимум 2 элемента.

Console.Clear();

Console.WriteLine("Введите последоватьльность натуральных чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int max1 = n;
int max2 = 0;

while (n != 0) {
     n = Convert.ToInt32(Console.ReadLine());
        if (max1 < n) {
            max2 = max1;
            max1 = n;
        }
        else if (n > max2 && n < max1)
            n = max2;
}
Console.WriteLine("Первое максимальное число: " + max1);
Console.WriteLine("Второе максимальное число: " + max2);