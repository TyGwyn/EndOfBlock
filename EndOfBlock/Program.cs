void Print1DArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+ ", ");
    }
    Console.WriteLine(arr[arr.Length-1]+ "]");
}
string [] Read1DArr(int len)

{
    string [] arr = new string[len];
    for (int i=0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите элемент массива");
        arr[i]=Console.ReadLine();
    }
    return arr;
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
string []DigitSum(string []arr)
{
    int len = arr.Length;
    string []final_arr =  new string[len];
    for (int i=0; i < len; i++)
    {  
        int res = 0;
        res = arr[i].Length;
            if (res <= 3)
            {
                final_arr[i] = arr [i];        
            }
    }
    return final_arr;
}
int ReadData(string line)
{
    Console.WriteLine(line);

    return int.Parse(Console.ReadLine() ?? "0");
}
int len = ReadData("Введите длину массива: ");
string []testArr= Read1DArr(len);
PrintData("Исходный массив");
Print1DArr(testArr);
string []finalArr = DigitSum(testArr);
PrintData("Искомый массив");
Print1DArr(finalArr);