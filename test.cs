List<int> list = new List<int> {1, 2, 5, 5, 5, 6};
List<int> newNumbers = new List<int> { 1 };
int x = 1;
for (int i = 1; i < list.Count; i++)
{
    try
    {
        x += (list[i] - list[i - 1]) / (list[i] - list[i - 1]);
    }
    catch { }
    newNumbers.Add(x);
}
