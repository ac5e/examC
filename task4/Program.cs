int n = Convert.ToInt32(Console.ReadLine());
var arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int counter = 1;
Array.Sort(arr);
for (int i = 0; i < n - 1; i++)
{
    if (arr[i] != arr[i+1])
    {
        counter++;
    }
}
System.Console.WriteLine(counter);
