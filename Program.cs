string[] array = {"Hello", "5", ":-)", "world", "-1234", "100"} ;

string[] res = new string[array.Length];

int count = 0;

for (int i = 0; i < array.Length; i++)
{   
    if (array[i].Length < 4)
    {
        res[count++] = array[i];
    }
}

Array.Resize(ref res, count);

Console.WriteLine($"Исходный массив: [ {string.Join(", ", array)} ]");
Console.WriteLine($"Результат: [ {string.Join(", ", res)} ]"); 