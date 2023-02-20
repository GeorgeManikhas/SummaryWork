string[] standartarray = new string[13] {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan", "098", "USB"};
string[] modarray = new string[standartarray.Length];

void Modifiedarray(string[] standartarray, string[] modarray)
{
    int count = 0;
    for (int i = 0; i < standartarray.Length; i++)
    {
    if(standartarray[i].Length <= 3)
        {
        modarray[count] = standartarray[i];
        count++;
        }
    }
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Modifiedarray(standartarray, modarray);
ShowArray(modarray);

