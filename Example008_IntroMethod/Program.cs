// класический стихийный подход int a1 = 15;// это девять пременных
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 2311;
//int c2 = 33;
//int a3 = 13;
//int b3 = 23;
//int c3 = 313;

//int max = a1;// определяем пременную max в которую порложим значение первой переменной
//if(b1 > max) max = b1;// проверка значений
//if(c1 > max) max = c1;

//if(a2 > max) max = a2;
//if(b2 > max) max = b2;
//if(c2 > max) max = c2;

//if(a3 > max) max = a3;
//if(b3 > max) max = b3;
//if(c3 > max) max = c3;

//Console.WriteLine(max);// вывести результат в консоле



// использование фунции
//кусочик кода
int Max(int arg1, int arg2, int arg3)//ввод фунции
{// тело метода
    int result = arg1;// хранится значение максимума
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;//возврвцает result
}//тело метода, вспомогательный механизм который ищет max из 3 чисел
//кусочик кода



int a1 = 112125;// это девять пременных
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;

//int max1 = Max(a1, b1, c1);// создаем переменную Max1, резултат работы фунции Max будет являться максимальным из 3 чисел  
//int max2 = Max(a2, b2, c2);// вторая группа чисел
//int max3 = Max(a3, b3, c3);// третия группа чисел
//int max = Max(max1, max2, max3);// принял на вход три переменных

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));//упрастить запись предыдущих строчек

Console.WriteLine(max);// вывести результат в консоле 