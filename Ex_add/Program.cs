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
    //Пишем строку в массив
    string[] numbersArray = initialString.Split(' ');
    
    int i = 0;
    //Первый и второй максимум - первый элемент массива
    int firstMaxNum = Convert.ToInt32(numbersArray[0]);
    int secondMaxNum = Convert.ToInt32(numbersArray[0]);

    while (Convert.ToInt32(numbersArray[i]) != 0) //Сравниваем только числа, которые перечислены до первого нуля в строке. Как только встречаем ноль - сравнение заканчивается
    {
        if (Convert.ToInt32(numbersArray[i]) > firstMaxNum)
        {
            secondMaxNum = firstMaxNum;
            firstMaxNum = Convert.ToInt32(numbersArray[i]);
        }  
        else
        {
            if (Convert.ToInt32(numbersArray[i])>secondMaxNum)
                secondMaxNum = Convert.ToInt32(numbersArray[i]);
        }    
        i++;
    }

   string outString = "Второе по величине значение из последовательности [" + initialString + "] (с условием поиска до первого нуля) равняется: " + secondMaxNum;
   Console.WriteLine(outString);

// Используя StreamWriter перезаписываем содержимое файла output.txt
using (StreamWriter writer = new StreamWriter("output.txt", false))
    await writer.WriteAsync(outString);

   
  
