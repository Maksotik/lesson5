// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

int size = 11;

diff_min_max ( random_array( size ) ); 


void diff_min_max ( double [] arr ){

double max = arr [0];
double min = arr [0];
double diff;

for ( int i = 0; i < size; i++ ){

    if( min > arr [i] ){
        min = arr [i];
    }
    if( max < arr [i] ){
        max = arr [i];
    }
   
}
diff = max - min;

Console.WriteLine($" * Максимальное значение- {max:0.00}      Минимальное значение- {min:0.00}");
Console.WriteLine($" * Разница между максимальным и минимальным значениями ->  {diff:0.00}");
}

double [] random_array( int size ){

Console.WriteLine(" * Массив из {0} случайных чисел: ", size);

double [] arr = new double [size];
Random rand = new Random();

    for( int i = 0; i < size; i++ ){
        arr[i] = rand.NextDouble();
        Console.Write($" {arr[i]:0.00} " );
    }
    Console.WriteLine();  
    return arr;   
}


