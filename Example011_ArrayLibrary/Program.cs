//                    аргумент 
void FillArray(int[] collection)//метод для заполнения массива. Иначе он будет заполнен нулямию. Первый метод!
{
    int length = collection.Length;//получаем длину нашего массиса
    int index = 0;//выбераем позицию
    while (index < length)
    {
        //                  счетчик случайного числа
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
// void- не чего не возвращает, называется void методом
void PrintArray(int[] col)//метод который будет печатоть массив
{
    int count = col.Length;//обозначаем количество элементов
    int position = 0;//задаем позицию
    while (position < count) //запускаем новый цикл
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find )//использование метода, метод отличный от войд, будет возвращать позицию
{
    int count = collection.Length;// определяем количество елементов
    int index = 0;//для целканья массивов
    int position = -1;
    while (index < count)//цикл
    {
        if(collection[index] == find)
        {
            position = index;
            break;   
        }
        index++;
    }
    return position;
}

int[] array = new int[10];//задали массив, создали навый массив в котором будет 10 элементов

FillArray(array);//заплнил наш массив
array[4] = 4;//добавили искуственно 4 больше
array[6] = 4;
PrintArray(array);//будет распечатывать наш массив
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);