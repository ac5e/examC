int n = Convert.ToInt32(Console.ReadLine());
var arr = new string[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToString(Console.ReadLine());
}
foreach (var items in arr)
{
    System.Console.WriteLine(items);
}
