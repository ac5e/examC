int n = Convert.ToInt32(Console.ReadLine());
var arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int minn = arr[0];
int id = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] < minn)
    {
        minn = arr[i];
        id = i;
    }
}
int maxx = arr[0];
int id1 = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] > maxx)
    {
        maxx = arr[i];
        id1 = i;
    }
}

System.Console.WriteLine("--------------------");
System.Console.WriteLine(minn);
System.Console.WriteLine(maxx);
if (id < id1)
{
    for (int i = id; i <= id1; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}
else 
{
    for (int i = id1; i <= id; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}
