//Поиск максимального значения среди элементов массива.

int Max(int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
int[] array = { 11, 21, 3241, 41, 15, 61, 17, 18, 19 };
array[0] = 12;

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);





//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max =Max(max1,max2,max3);
//Console.WriteLine(array[0]); // - выведение значения по индексу
//array[0] = 12; // - запись значения по индексу в массив
