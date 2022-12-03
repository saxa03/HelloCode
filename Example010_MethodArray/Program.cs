int[] array = {11, 23, 36, 42, 15, 16, 37, 84, 29};
int n = array.Length;
int find = 6;
int index = 0;

while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
      
    }
    index++;
}