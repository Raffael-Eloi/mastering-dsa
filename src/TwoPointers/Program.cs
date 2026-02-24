Console.WriteLine("=== Two Pointers & Sliding Window ===\n");

// -----------------------------------------
// 1. Two Sum on Sorted Array (converging pointers)
// -----------------------------------------
Console.WriteLine("--- Two Sum (sorted array) ---");
int[] sorted = { 1, 3, 5, 7, 9, 11 };
Console.WriteLine($"Array: [{string.Join(", ", sorted)}]");

var pair1 = TwoSum(sorted, 10);
Console.WriteLine($"Target 10: indices [{pair1.Item1}, {pair1.Item2}] -> ({sorted[pair1.Item1]} + {sorted[pair1.Item2]})");

var pair2 = TwoSum(sorted, 16);
Console.WriteLine($"Target 16: indices [{pair2.Item1}, {pair2.Item2}] -> ({sorted[pair2.Item1]} + {sorted[pair2.Item2]})");

// -----------------------------------------
// 2. Container With Most Water (converging pointers)
// -----------------------------------------
Console.WriteLine("\n--- Container With Most Water ---");
int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
Console.WriteLine($"Heights: [{string.Join(", ", heights)}]");
Console.WriteLine($"Max water: {MaxArea(heights)}"); // 49 (between index 1 and 8)

// -----------------------------------------
// 3. Remove Duplicates from Sorted Array (fast/slow pointer)
// -----------------------------------------
Console.WriteLine("\n--- Remove Duplicates (in-place) ---");
int[] nums = { 1, 1, 2, 2, 3, 4, 4, 5 };
Console.WriteLine($"Before: [{string.Join(", ", nums)}]");
int newLength = RemoveDuplicates(nums);
Console.Write($"After:  [");
for (int i = 0; i < newLength; i++)
    Console.Write(i > 0 ? $", {nums[i]}" : $"{nums[i]}");
Console.WriteLine($"] (length={newLength})");

// -----------------------------------------
// 4. Longest Substring Without Repeating Characters (sliding window)
// -----------------------------------------
Console.WriteLine("\n--- Longest Substring Without Repeating Chars (Sliding Window) ---");
Console.WriteLine($"'abcabcbb' -> {LongestSubstring("abcabcbb")}"); // 3 ("abc")
Console.WriteLine($"'bbbbb'    -> {LongestSubstring("bbbbb")}");    // 1 ("b")
Console.WriteLine($"'pwwkew'   -> {LongestSubstring("pwwkew")}");   // 3 ("wke")
Console.WriteLine($"''         -> {LongestSubstring("")}");          // 0

// =============================================
// Implementations
// =============================================

// Two Sum: use two pointers converging from both ends
// Time: O(n), Space: O(1)
static (int, int) TwoSum(int[] arr, int target)
{
    int left = 0, right = arr.Length - 1;

    while (left < right)
    {
        int sum = arr[left] + arr[right];

        if (sum == target)
            return (left, right);

        if (sum < target)
            left++;
        else
            right--;
    }

    return (-1, -1); // not found
}

// Container With Most Water: maximize area between two lines
// Time: O(n), Space: O(1)
static int MaxArea(int[] height)
{
    int left = 0, right = height.Length - 1;
    int maxArea = 0;

    while (left < right)
    {
        int width = right - left;
        int h = Math.Min(height[left], height[right]);
        maxArea = Math.Max(maxArea, width * h);

        // Move the shorter line inward (greedy: only way to potentially increase area)
        if (height[left] < height[right])
            left++;
        else
            right--;
    }

    return maxArea;
}

// Remove Duplicates: slow pointer tracks unique position, fast pointer scans
// Time: O(n), Space: O(1)
static int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0) return 0;

    int slow = 0; // position of last unique element

    for (int fast = 1; fast < nums.Length; fast++)
    {
        if (nums[fast] != nums[slow])
        {
            slow++;
            nums[slow] = nums[fast];
        }
    }

    return slow + 1; // length
}

// Longest Substring Without Repeating: sliding window with hash set
// Time: O(n), Space: O(min(n, alphabet size))
static int LongestSubstring(string s)
{
    var chars = new HashSet<char>();
    int maxLen = 0;
    int left = 0;

    for (int right = 0; right < s.Length; right++)
    {
        // Shrink window until no duplicate
        while (chars.Contains(s[right]))
        {
            chars.Remove(s[left]);
            left++;
        }

        chars.Add(s[right]);
        maxLen = Math.Max(maxLen, right - left + 1);
    }

    return maxLen;
}
