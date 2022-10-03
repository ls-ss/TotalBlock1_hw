/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
задать на старте выполнения алгоритма.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */
Console.Clear();

/* Ф-ция CreateArray создает массив и присваивает его array.
   Первый аргумент ф-ции: кол-во строк в массиве; второй - длина строки */
string[] array = CreateArray(6, 20);
PrintArray(array);       // Выводим созданный массив на консоль
Console.Write(" ---> "); // Вспомогательная надпись

/* Ф-ция NewArray создает новый массив по определенным правилам и присваивает его newArray*/
string[] newArray = NewArray(array);
if( newArray.Length != 0){
    PrintArray(newArray); // Выводим созданный массив на консоль
    Console.WriteLine();
}
else Console.WriteLine("[]");


/* Ф-ция заполняющая случайными печатными символами ОДНОМЕРНЫЙ МАССИВ 
длиной [LengthArray] и строками плавающей длины в пределах [1...maxLengthString] */
string[] CreateArray(int LengthArray, int maxLengthString){  
    Random rand = new Random(); // Объявление переменной для генерации чисел
    string[] array = new string[LengthArray]; //Создаем массив длиной LengthArray
    int n = 0; // ДЛИНА СТРОКИ. Создаем ее здесь, чтобы в цикле не инициализировать ее каждый раз
    byte randNum = 0;   // Переменная случайного числа
    string temp_s = ""; // Строковая переменная, куда будем добавлять геннерируемые символы
    
    // Заполняем массив случайными печатными символами
    for( int i = 0; i < LengthArray; i++ ){
        // Длина следующей строки массива (от 1 до maxLengthString)
        n = rand.Next(1, maxLengthString + 1);
        
        for(int j = 0; j < n ; j++){    // Цикл заполняет строку случайными печатными символами
            randNum = (byte)rand.Next(32, 127); //Задаем случайное число в диапазоне 32..126
            temp_s += (char)randNum;
        }
        array[i] = temp_s;
        temp_s = "";
    }
    return array;
}


// Ф-ция из полученного массива строк формирует новый массив из строк, длина которых <= 3 символам.
string[] NewArray(string [] array){
    int n = 0; // Переменная для хранения кол-ва строк с длиной <=3  
    for( int i = 0; i < array.Length; i++ ){
        if( array[i].Length <= 3 ) n++;
    }

    string[] newArray = new string[n]; //Создаем массив на n строк
    n = 0;
    for( int i = 0; i < array.Length; i++ ){
        if( array[i].Length <= 3 ){
            newArray[n] = array[i];
            n++;
        }
    } 
    return newArray;
}


// Ф-ция вывода одномерного массива в консоль
void PrintArray(string[] array){
    Console.Write("[\"");
    for(int i = 0; i < array.Length; i++){
        Console.Write( array[i] );
        if( i < array.Length -1 )
            Console.Write("\", \"");
    } 
    Console.Write("\"]");    
}