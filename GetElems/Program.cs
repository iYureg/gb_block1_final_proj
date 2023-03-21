// Программа из данного массива строк,
// формирует массив из строк длина которых меньше или равна 3

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]


string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };

int elSize = 3;
int resSize = GetSize(array);

string[] resultArr = GetArray(array, resSize);

Console.Clear();
Console.WriteLine($"Массив строк -> [ {String.Join(", ", array)} ]");
Console.WriteLine();
Console.WriteLine($"[ {String.Join(", ", resultArr)} ] <- Искомый массив");

string[] GetArray(string[] arr, int size)
{
    size = size == 0 ? 1 : size;

    string[] result = new string[size];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= elSize)
        {
            result[j] = arr[i];
            j++;

        } 
    }
    return result;
}



int GetSize(string[] arr){
    int arrSize = 0;
    foreach(string elem in arr)
    {
        arrSize += elem.Length <= elSize ? 1 : 0;
    }
    return arrSize;
}