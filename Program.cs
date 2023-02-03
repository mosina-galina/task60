// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
int[,,] array = new int[2, 2, 2];
NewArray(array);
void NewArray(int[,,] array)
{
    int p = 10;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                array[i, j, k] = array[i, j, k] + p;
                p = p + 10 ;
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
         }
     }  
}
