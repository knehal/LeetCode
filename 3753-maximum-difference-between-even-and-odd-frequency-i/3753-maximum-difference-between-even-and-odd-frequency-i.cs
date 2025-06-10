public class Solution {
    public int MaxDifference(string s) {
        List<char> chars = [];
        var allinputchar = s.ToCharArray();
        List<int> diff = [];
        int count = 0;

        foreach(var item in s.ToCharArray())
        {
            if(!chars.Contains(item))
            {
                chars.Add(item);
            }
        }

        foreach(var item in chars)
        {
            foreach(var item2 in allinputchar)
            {
                if(item == item2)
                {
                    count++;
                }
            }
            diff.Add(count);
            count = 0;
        }

        int odd = diff.Where(x=>x % 2 != 0).Max();
        int even = diff.Where(x=>x % 2 == 0).Min();
        return odd - even;
    }
}