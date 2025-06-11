public class Solution {
    public int RomanToInt(string s) {
        Dictionary<string, int> RomanValue = new()
        {
            {"I",1},
            {"V",5},
            {"X",10},
            {"L",50},
            {"C",100},
            {"D",500},
            {"M",1000},
        };

        char[] inputroman = [.. s];
        int count = 0;
        char lastchar = new();

        foreach(var item in inputroman.Reverse())
        {
            if(RomanValue.TryGetValue(item.ToString(), out int value))
            {
                switch(lastchar, item)
                {
                    case('V','I'):
                    case('X','I'):
                    case('L','X'):
                    case('C','X'):
                    case('D','C'):
                    case('M','C'):
                        count -= value;
                        break;
                    default:
                        count += value;
                        break;
                }
                lastchar = item;
            }
        }
        return count;
    }
}