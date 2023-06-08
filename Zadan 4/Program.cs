//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Random rnd = new Random();
bool FindNumInArr(int FindNum, int[,,] FindArr ){//проверка уникальности числа, если выходит false то число ранее в массиве не встречалось
    bool FindResult = false;
    for (int z = 0; z < FindArr.GetLength(2); z++){
        for (int y = 0; y < FindArr.GetLength(1); y++){
            for (int x = 0; x < FindArr.GetLength(0); x++){
                if(FindArr[z, y, x] == FindNum){
                    FindResult = true;
                    break;
                }
            }
        }
    }
    return FindResult;
}
int[,,] GenNewArrRandUniq(int[,,] GenNewNumArr){
    bool CheckUnique = false;
    int RandInt = 0;
    for (int dimension = 0; dimension < GenNewNumArr.GetLength(2); dimension++){
        for (int strings = 0; strings < GenNewNumArr.GetLength(1); strings++){
            for (int columns = 0; columns < GenNewNumArr.GetLength(0);){
                RandInt = rnd.Next(10, 99);
                CheckUnique = FindNumInArr(RandInt, GenNewNumArr);
                if(CheckUnique == false){
                    GenNewNumArr[strings, columns, dimension] = RandInt;
                    columns++;
                }
            }
        }
    }
    return GenNewNumArr;
}
void PrintArray3D(int[,,] Print3DArr){
    for (int dimension = 0; dimension < Print3DArr.GetLength(2);dimension++){
        for (int strings = 0; strings < Print3DArr.GetLength(0); strings++){
            for (int columns = 0; columns < Print3DArr.GetLength(1); columns++){
                if(columns < Print3DArr.GetLength(1) - 1){
                    Console.Write($"{Print3DArr[strings, columns, dimension]}({strings},{columns},{dimension}) | ");
                }
                else{
                    Console.Write($"{Print3DArr[strings, columns, dimension]}({strings},{columns},{dimension})");
                }
            }
        Console.WriteLine();
        }
    }
}
int[,,] array = new int[2,2,2];
array = GenNewArrRandUniq(array);
PrintArray3D(array);