// Question 1
static int[] Medians(int[] values, int k)
{
    Array.Sort(values);

    int n = values.Length;
    int m = (k - 1) / 2;

    int minMedian = values[m];
    int maxMedian = values[n - k + m];

    return new int[] { maxMedian, minMedian };
}

// Question 2
static long MinCostToMakeDistinct(int[] conc, int[] price)
{
    int n = conc.Length;

    var functions = new List<(int conc, int price)>();

    for (int i = 0; i < n; i++)
        functions.Add((conc[i], price[i]));

    functions.Sort((a, b) =>
    {
        if (a.conc == b.conc)
            return b.price.CompareTo(a.price);
        return a.conc.CompareTo(b.conc);
    });

    long totalCost = 0;
    int prev = int.MinValue;

    foreach (var func in functions)
    {
        int currentConc = func.conc;

        if (currentConc <= prev)
        {
            int target = prev + 1;
            int increments = target - currentConc;
            totalCost += (long)increments * func.price;
            prev = target;
        }
        else
        {
            prev = currentConc;
        }
    }

    return totalCost;
}