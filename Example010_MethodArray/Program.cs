int[] array = { 12, 13, 45, 76, 78, 32, 54, 45, 78 };

int n = array.Length;
int find = 78;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    //index = index +1;
    index++;
}