/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
задать на старте выполнения алгоритма.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */
Console.Clear();

Console.WriteLine("====");
string [] array = CreateArrayOne(3, 20);
//PrintArray(array);
Console.WriteLine("****");

/* Ф-ция заполняющая случайными печатными ASCII-символами 
   ОДНОМЕРНЫЙ МАССИВ длиной [LengthArray]
   элементами плавающей длиной в пределах [1...maxLengthString] */
string [] CreateArrayOne(int LengthArray, int maxLengthString){  
    Random rand = new Random(); // Объявление переменной для генерации чисел
    string [] array = new string[LengthArray]; //Создаем массив длиной LengthArray
    int n = 0; // ДЛИНА ЭЛЕМЕНТА. Создаем ее здесь, чтобы в цикле не инициализировать ее каждый раз
    byte randNum = 0;

    string temp_s = ""; // Создаем строковую переменную, куда будем добавлять геннерируемые символы
    
    // Заполняем массив случайными печатными ASCII-символами
    for(int i = 0; i < LengthArray; i++){  // Цикл, который задает кол-во итераций, равное элементам массива array
        // Задаем случайным образом длину следующего элемента массива (от 1 до maxLengthString)
        n = new Random().Next(1, maxLengthString + 1);
        Console.WriteLine($"n= {n}");
        // Заполняем строку печатными символами случайным образом
        for(int j = 0; j < n ; j++){           
            randNum = (byte)rand.Next(32, 127); //Задаем случайное число в диапазоне 32..126
            temp_s += (char)randNum;
    //       Console.WriteLine($"randNum= {randNum}, temp_s= {temp_s}");
        }

        array[i] = temp_s;
       
        Console.WriteLine($"array[{i}]= {array[i]}");
        Console.WriteLine();
        temp_s = "";
    }
    Console.WriteLine();
    return array;
}
/*
// Ф-ция вывода двумерного массива в консоль ввиде таблицы.
void PrintArray(string[] array){
    Console.WriteLine($"Массив размером {array.Length}:");

    for(int i = 0; i < array.Length; i++){
        Console.Write( array[i] );
        Console.WriteLine();
    }     
}
*/
/*
    Random rand = new Random(); // объявление переменной для генерации чисел
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            arrayMxN[i,j] = Convert.ToString(rand.Next(-99, 100)/10.0);
        }
    }
// arrayMxN[i,j] = Convert.ToString(rand.Next(-99, 100)/10.0);

.GetEncoding("windows-1251")
*/