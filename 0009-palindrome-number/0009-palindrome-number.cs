public class Solution {
    public bool IsPalindrome(int x) {
        string reversed = new (Math.Abs((long)x).ToString().Reverse().ToArray());

        if (x < 0)
        {
            return false;
        }
        return x == Convert.ToInt64(reversed);
    }
}