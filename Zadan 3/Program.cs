//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Random rnd = new Random();
int Strings = 2;
int Columns = 2;
int[,] CreateNewArray(){//создание нового двумерного массива случайного размера заполненого случайными числами
    int[,] NewArray = new int[Strings, Columns];
    for (int NewStrings = 0; NewStrings < Strings; NewStrings++){//тут перебор строк идёт
        for (int NewColumns = 0; NewColumns < Columns; NewColumns++){//тут перебор столбцов
            NewArray[NewStrings,NewColumns] = rnd.Next(0,9);//пусть будут числа от 0 до 9 для большего разнообразия, плюс я придумал как сделать так, чтобы двузначные числа не ломали внешний вид таблицы
        }
    }
    return NewArray;
}
void PrintMat(int[,] ArrayToPrint, string text){
    Console.WriteLine(text);
    for (int stepstring = 0; stepstring < Strings; stepstring++){
        for (int stepcolumn = 0; stepcolumn < Columns; stepcolumn++){
            if(stepcolumn < Columns - 1){
                Console.Write($"| {ArrayToPrint[stepstring, stepcolumn]} ;");
            }
            else{
                Console.Write($" {ArrayToPrint[stepstring, stepcolumn]} |");
            }
        }
        Console.WriteLine();
    }
}
int[,] MatMult(int[,] MatA, int[,] MatB){
    int[,] MatResult = new int[Strings, Columns];
    for (int StepStr = 0; StepStr < Strings; StepStr++){
        for (int StepCol = 0; StepCol < Columns; StepCol++){
            for (int Res = 0; Res < Columns; Res++){
                MatResult[StepStr, StepCol] += MatA[StepStr, Res] * MatB[Res, StepCol];
            }
        }
    }
    return MatResult;
}
int[,] MatA = CreateNewArray();
PrintMat(MatA, "Матрица A");
int[,] MatB = CreateNewArray();
PrintMat(MatB, "Матрица B");
int[,] MatC = MatMult(MatA, MatB);
PrintMat(MatC, "Матрица C");