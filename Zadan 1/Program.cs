Random rnd = new Random();
int Strings = rnd.Next(10,20);//создаю переменные с количеством столбцов и строк в начале программы, чтобы потом все методы могли на эти данные опираться
int Columns = rnd.Next(10,20);
int[,] CreateNewArray(){//создание нового двумерного массива случайного размера заполненого случайными числами
    int[,] NewArray = new int[Strings, Columns];
    for (int NewStrings = 0; NewStrings < Strings; NewStrings++){//тут перебор столбцов идёт
        for (int NewColumns = 0; NewColumns < Columns; NewColumns++){//тут перебор столбцов
            NewArray[NewStrings,NewColumns] = rnd.Next(0,99);//пусть будут числа от 0 до 99, так будет разнообразнее визуально
        }
    }
    return NewArray;
}
void Print2DArray(int[,] ArrayToPrint){
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
    for (int stepstring = 0; stepstring < Strings; stepstring++){
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
        }
        Console.WriteLine();
    }
}
int[,] SortArray(int[,] SortArray){
    int temp = 0;
    int StepColumn = 0;
    for(int SortStrings = 0; SortStrings < Strings; SortStrings++){
        StepColumn = 0;
        for (int StepSort = Columns - 1; StepSort > StepColumn;){
            if(SortArray[SortStrings, StepSort] > SortArray[SortStrings, StepSort - 1]){
                temp = SortArray[SortStrings, StepSort];
                SortArray[SortStrings, StepSort] = SortArray[SortStrings, StepSort - 1];
                SortArray[SortStrings, StepSort - 1] = temp;
                StepSort--;
            }
            else{
                StepSort--;
            }
            if(StepSort==StepColumn){
                StepSort = Columns - 1;
                StepColumn++;
            }
        }
    }
    return SortArray;
}
int[,] array = CreateNewArray();
Console.WriteLine("До сортировки");
Print2DArray(array);
array = SortArray(array);
Console.WriteLine("После сортировки");
Print2DArray(array);