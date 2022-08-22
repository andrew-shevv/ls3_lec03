// minmax sort

int[] assortedCherries = {2,5,1,7,3,6,9,4,8};

void Print(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void minMaxSort(int[] array){
    for (int i = 0; i < array.Length - 1; i++){
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] < array[minPos]){
                minPos = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

Print(assortedCherries);
minMaxSort(assortedCherries);
Print(assortedCherries);