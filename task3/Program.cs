int n = Convert.ToInt32(Console.ReadLine());
var arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n - 1; i+=2)
{
    int non;
    non = arr[i];
    arr[i] = arr[i+1];
    arr[i+1] = non;
}
for (int i = 0; i < n; i++)
{
    System.Console.WriteLine(arr[i]);
}
