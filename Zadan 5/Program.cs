int[,] lineFilling(int[,] FillingArray, int stepfill){//я пытался придумать что то получше, но у меня к сожалению не вышло, а когда придумал более универсальный и масштабируемый способ, то на переделывание не осталось времени
    if (stepfill == 1){
        int CurrentNum = FillingArray[0, 0];
        for (int step = 0; step < FillingArray.GetLength(0); step++){
            CurrentNum++;
            FillingArray[0, step] = CurrentNum;
        }
        return FillingArray;
    }
    if (stepfill == 2){
        int CurrentNum = FillingArray[0, FillingArray.GetLength(0) - 1];
        for (int step = 1; step < FillingArray.GetLength(1); step++){
            CurrentNum++;
            FillingArray[step, FillingArray.GetLength(0) - 1] = CurrentNum;
        }
        return FillingArray;
    }
    if (stepfill == 3){
    int CurrentNum = FillingArray[FillingArray.GetLength(1) - 1, FillingArray.GetLength(0) - 1];
    for (int step = 2; step >= 0; step--){
        CurrentNum++;
        FillingArray[FillingArray.GetLength(1) - 1, step] = CurrentNum;
    }
        return FillingArray;
    }
    if (stepfill == 4){
    int CurrentNum = FillingArray[FillingArray.GetLength(1) - 1, 0];
    for (int step = 2; step > 0; step--){
        CurrentNum++;
        FillingArray[step, 0] = CurrentNum;
    }
        return FillingArray;
    }
    if (stepfill == 5){
    int CurrentNum = FillingArray[1, 0];
    for (int step = 1; step < FillingArray.GetLength(0) - 1; step++){
        CurrentNum++;
        FillingArray[1, step] = CurrentNum;
    }
        return FillingArray;
    }
    if (stepfill == 6){
    int CurrentNum = FillingArray[1, 2];
    for (int step = 2; step > 0; step--){
        CurrentNum++;
        FillingArray[2, step] = CurrentNum;
    }
        return FillingArray;
    }
    return FillingArray;
}
int[,] array = new int[4, 4];
for (int step =1; step<7; step++){
    array = lineFilling(array, step);
}
for (int step = 0; step < array.GetLength(1); step++){
    for (int col = 0; col < array.GetLength(0); col++){
        if(array[step,col]<10){
        Console.Write($"|0{array[step,col]}|");
        }
        else{
        Console.Write($"|{array[step,col]}|");
        }
    }
    Console.WriteLine();
}