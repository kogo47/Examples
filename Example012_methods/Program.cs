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
for (int i = 2; i <= 10; i++)
{
    //j-используем для внутренего счетчика
    for (int j = 2; j <= 10; j++)
    {
                        //интраполяция строк
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}