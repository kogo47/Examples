//  функция Max    
int Max(int arg1, int arg2, int arg3)//ввод фунции
{// тело метода
    int result = arg1;// хранится значение максимума
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;//возврвцает result
}//тело метода, вспомогательный механизм который ищет max из 3 чисел
//кусочик кода
//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };//задаем массив
//array[0] = 12;//это строчка обрацаеться к массиву и записать в него зеначение
//                      0
// Console.WriteLine(array[4]);// обратиться к массиву и получить значение сотвествующего элемента по указанному индексу

// max переменная 
int result = Max (
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
); 
Console.WriteLine(result);
