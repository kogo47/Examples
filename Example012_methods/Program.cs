//вид метода 1(который не чего не возврващает)
// void Method1()
// {
//     Console.WriteLine("Автор Савченко Сергей ");
// }
//Method1();//вызов метода //()- обезательно надоставить











// вид метода 2(метод который не чего не возвращает,- 
//но может принимать какието аргументы)
             //аргумент
// void Methods2(string msg)
// {
//     Console.WriteLine(msg);
// }
// //Methods2(msg: "Текст сообщения ");//именованный метод надо если будет несколько методов
//                //аргументы
// void Methods21(string msg, int count)
// {
//     int i = 0;//в этом случии будет использоваться переменная- 
//     //count для того что бы показывать на экране определенное количество сообщений-
//     // которые будут передоваться в наш метод
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;// увелечение на 1 называют экриментом-
//                 // а уменьшение на 1 называют тетэкримент
//     }
// }
// //Methods21(msg: "Текст", count: 4 );
// //Methods21(count: 4, msg: "новый текст");




// //метод 3(что то возвращает)
//         //аргументов не принемает
// int Methods3()
// {
//     return DateTime.Now.Year;//обезательное использования
// }

// int year = Methods3();//int year индификатор переменной Methods3 имя метода
//Console.WriteLine(year);








//метод 4(который что то принимает и что то возвращает)
//  string Method4(int count, string text)
//  {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
//  }
//  string res = Method4(10, "z");
//  Console.WriteLine(res);







//метод с использованием цикла for
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)   
// {
//     result = result + text;
// }
// return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);




//метод использования цикла в цикле
// for (int i = 2; i <= 10; i++)
// {
//     //j-используем для внутренего счетчика
//     for (int j = 2; j <= 10; j++)
//     {
//                         //интраполяция строк
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }




//Дан текст. В тексте нужно все пробелы заменить черточками, 
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
//маленькими “с”.

// string text= "— Я думаю, — сказал князь, улыбаясь, — что, " 
//            + "ежели бы вас послали вместо нашего милого "
//            + "Винценгероде, вы бы взяли приступом согласие "
//            + "прусского короля. Вы так красноречивы. Вы "
//            + "дадите мне чаю?";



// string s = "qwerty"
//             012345
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);


// Replace             Заменить
// string              строку
// WriteLine           Линия записи
// length              длина
// char old Value      символа старое значение
// char newValue       символа Новое значение




// 1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со 
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные 
// элементы

// Задачи
// Максимум в массиве
// Минимум в массиве
// Максимум в упорядоченном массиве
// Подсчет цифр числа

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)//
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
        {
    minPosition = j;
    }
 }
 int temporary = array[i];
 array[i] = array[minPosition];
 array[minPosition] = temporary;
 }
}



PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
