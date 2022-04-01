// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int size = 8;
int count = 0;
int [] arr = new int [size];
Random rand = new Random();

Console.WriteLine(" Массив трехзначных чисел: ");
for( int i = 0; i < size; i++ ){
    arr[i] = rand.Next(100, 999);
    Console.Write(" {0} ", arr[i]);
    
    if( arr[i] % 2 == 0 )
        count++; 
}
Console.WriteLine();
Console.WriteLine(" Количество четных чисел в массиве - {0} ",count);