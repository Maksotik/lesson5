// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int size = 8;
int count = 0;
int [] arr = new int [size];
Random rand = new Random();

Console.WriteLine(" Массив чисел: ");
for( int i = 0; i < size; i++ ){
    arr[i] = rand.Next(0, 9);
    Console.Write(" {0} ", arr[i]);
    
    if( i % 2 != 0 )
        count += arr[i]; 
}
Console.WriteLine();
Console.WriteLine(" Сумма чисел нечетных индексов массива - {0} ",count);