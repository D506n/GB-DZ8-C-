//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Random rnd = new Random();
int Strings = rnd.Next(10,20);//создаю переменные с количеством столбцов и строк в начале программы, чтобы потом все методы могли на эти данные опираться
int Columns = rnd.Next(10,20);
int[,] CreateNewArray(){//создание нового двумерного массива случайного размера заполненого случайными числами
    int[,] NewArray = new int[Strings, Columns];
    for (int NewStrings = 0; NewStrings < Strings; NewStrings++){//тут перебор столбцов идёт
        for (int NewColumns = 0; NewColumns < Columns; NewColumns++){//тут перебор столбцов
            NewArray[NewStrings,NewColumns] = rnd.Next(0,99);//пусть будут числа от 0 до 99 для большего разнообразия, плюс я придумал как сделать так, чтобы двузначные числа не ломали внешний вид таблицы
        }
    }
    return NewArray;
}
void Print2DArrayAndMinSum(int[,] ArrayToPrint){
    int MinSum = int.MaxValue; //Назначение этой переменной большого числа нужно для того, чтобы потом корректно сработало сравнение MinSum>TempSum
    int TempSum = 0;
    int MinString = 0;
    for (int stepstring = 0; stepstring < Strings; stepstring++){
        for (int stepcolumn = 0; stepcolumn < Columns; stepcolumn++){
        TempSum = TempSum + ArrayToPrint[stepstring,stepcolumn]; 
        }
        if (TempSum<MinSum){
            MinString = stepstring;
            MinSum = TempSum;
        }
        TempSum = 0;
    }
    Console.WriteLine("Таблица чисел: ");
    Console.Write("№ ст.:       ");
    for (int step = 1; step <= Columns; step++){
        if(step<9){ //без этой проверки таблица выглядит очень некрасиво, когда столбцов больше 9
            Console.Write($"{step}      ");
        }
        else{
            Console.Write($"{step}     ");
        }
    }
    Console.WriteLine();
    TempSum = 0;
    for (int stepstring = 0; stepstring < Strings; stepstring++){
        if (stepstring == MinString){
            Console.ForegroundColor = ConsoleColor.Green;
        }
        if (stepstring < 9){ //без этой проверки таблица выглядит очень некрасиво, когда строк больше 9
        Console.Write($"Строка {stepstring+1}: ");
        }
        else{
            Console.Write($"Строка {stepstring+1}:");
        }
        for (int stepcolumn = 0; stepcolumn < Columns; stepcolumn++){
            if (ArrayToPrint[stepstring, stepcolumn] > 9){//а без этой проверки двузначное число сломает внешний вид таблицы
                Console.Write($"| {ArrayToPrint[stepstring, stepcolumn]} | ");
            }
            else{
            Console.Write($"|  {ArrayToPrint[stepstring, stepcolumn]} | ");
            }
            TempSum = TempSum + ArrayToPrint[stepstring, stepcolumn];
        }
        Console.Write($"Сумма элементов в строке: {TempSum}");
        Console.WriteLine();
        Console.ResetColor();
        TempSum = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой чисел: {MinString + 1}");
}
int[,] array = CreateNewArray();
Print2DArrayAndMinSum(array);