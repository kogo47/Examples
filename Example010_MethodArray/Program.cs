int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };//определяем новый массив

int n = array.Length;//обрацение к элементам массива, возвращает длину или количество массива
//         4 
int find = 18;// пользователь просит вести число

int index = 0;//устанавливаем счетчик 

//начало цикла
while (index < n)//тут мы проверяем
{
    if(array[index]== find)//это равенство или совпадение 
    {
        Console.WriteLine(index);//выыодит в консоль
        break;//оператор прерывания
    }
    //index = index + 1;
    index++;//увелечение значения индекса
}