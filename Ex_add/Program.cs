//========================================================================================================================
// (https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=3&id_topic=35&id_problem=223)
// ВАЖНО!!!!
// Пример:
// 5
// 4
// 3
// 2
// 1
// 0
// Вывод:
// 4
//========================================================================================================================

    // Открываем текстовый файл, используя StreamReader.
    var sr = new StreamReader("input.txt");
    // Сохраняем строку входных чисел в переменной для вывода результата
    string initialString = sr.ReadToEnd();
    //Пишем строку в массив, разделители - пробелы
    string[] numbersArray = initialString.Split(' ');
    
    
    int tmp = 0;
    //Первый и второй максимум - нулевой элемент массива
    int firstMaxNum = Convert.ToInt32(numbersArray[0]); //объявляем нулевой элемент максимальным
    int secondMaxNum = Convert.ToInt32(numbersArray[1]); //второй максимум равен первому элементу
    if (secondMaxNum>firstMaxNum) //если второе больше первого - меняем местами
    {
        tmp = firstMaxNum;
        firstMaxNum = secondMaxNum;
        secondMaxNum = tmp;
    }
    int i = 1; //первые два сравнили - начинаем с третьего числа
    int num = secondMaxNum;
    //        Console.WriteLine ("i="+i+", num="+num);

    while ((num != 0)&(i <= numbersArray.Count()-1)) //Сравниваем только числа, которые перечислены до первого нуля в строке. Как только встречаем ноль - сравнение заканчивается. Если ноля нет - сравниваем все числа.
    {
        Console.WriteLine ("i="+i+", num="+num);
        if (i != numbersArray.Count()-1)  // иначе - последняя итерация - следующего элемента массива не существует
            num = Convert.ToInt32(numbersArray[i+1]);
        if ( num >= firstMaxNum)
        {
            secondMaxNum = firstMaxNum;
            firstMaxNum = num;
        }  
        else
        {
            if (num >= secondMaxNum)
                secondMaxNum = num;
        }   
        i++;
    }

   string outString = "Второе по величине значение из последовательности [" + initialString + "] (с условием поиска до первого нуля) равняется: " + secondMaxNum;
   Console.WriteLine(outString);

// Используя StreamWriter перезаписываем содержимое файла output.txt
using (StreamWriter writer = new StreamWriter("output.txt", false))
    await writer.WriteAsync(outString);