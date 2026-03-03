Console.WriteLine("=== Interview Questions ===\n");

// =============================================
// Question 1: Median of Subsequences
// =============================================
Console.WriteLine("--- Question 1: Max/Min Median of Subsequences ---");
Console.WriteLine("Given values=[1,2,3], k=2");
Console.WriteLine("Find max and min median over all subsequences of length k.\n");

int[] values1 = { 1, 2, 3 };
int[] result1 = Medians(values1, 2);
Console.WriteLine($"Max median: {result1[0]}, Min median: {result1[1]}");
// Expected: Max=2, Min=1

int[] values2 = { 5, 3, 1, 4, 2 };
int[] result2 = Medians(values2, 3);
Console.WriteLine($"\nvalues=[5,3,1,4,2], k=3");
Console.WriteLine($"Max median: {result2[0]}, Min median: {result2[1]}");

// =============================================
// Question 2: Minimum Cost to Make Distinct
// =============================================
Console.WriteLine("\n--- Question 2: Min Cost to Make Concurrency Limits Distinct ---");
Console.WriteLine("conc=[5,2,5,3,3], price=[3,7,8,6,9]");
Console.WriteLine("Make all concurrency limits distinct with minimum cost.\n");

int[] conc = { 5, 2, 5, 3, 3 };
int[] price = { 3, 7, 8, 6, 9 };
long cost = MinCostToMakeDistinct(conc, price);
Console.WriteLine($"Minimum cost: {cost}");
// Expected: 9 (bump function 0 from 5->6 costs 3, bump function 3 from 3->4 costs 6)

// =============================================
// Question 3: Longest Palindromic Substring
// =============================================
Console.WriteLine("\n--- Question 3: Longest Palindromic Substring ---");
Console.WriteLine("Given a string, find the longest palindromic substring.\n");

string s1 = "babad";
Console.WriteLine($"s=\"{s1}\" -> \"{LongestPalindrome(s1)}\"");
// Expected: "bab" (or "aba")

string s2 = "cbbd";
Console.WriteLine($"s=\"{s2}\" -> \"{LongestPalindrome(s2)}\"");
// Expected: "bb"

string s3 = "a";
Console.WriteLine($"s=\"{s3}\" -> \"{LongestPalindrome(s3)}\"");
// Expected: "a"

string s4 = "racecar";
Console.WriteLine($"s=\"{s4}\" -> \"{LongestPalindrome(s4)}\"");
// Expected: "racecar"

// =============================================
// Solutions
// =============================================

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

// Question 3
static string LongestPalindrome(string s)
{
    if (s.Length <= 1) return s;

    int start = 0, maxLen = 1;

    for (int i = 0; i < s.Length; i++)
    {
        // Odd-length palindromes (center = single char)
        int len1 = ExpandAroundCenter(s, i, i);
        // Even-length palindromes (center = gap between chars)
        int len2 = ExpandAroundCenter(s, i, i + 1);

        int len = Math.Max(len1, len2);
        if (len > maxLen)
        {
            maxLen = len;
            start = i - (len - 1) / 2;
        }
    }

    return s.Substring(start, maxLen);
}

static int ExpandAroundCenter(string s, int left, int right)
{
    while (left >= 0 && right < s.Length && s[left] == s[right])
    {
        left--;
        right++;
    }
    return right - left - 1;
}
