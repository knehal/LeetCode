public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> result = [];
        foreach(var item in nums.Select((value, index) => new {value, index}))
        {
            foreach(var item2 in nums.Select((value, index) => new {value, index}))
            {
                if(item.value + item2.value == target && item.index != item2.index)
                {
                    result.Add(item.index);
                    result.Add(item2.index);
                    break;
                }
            }
            if(result.Count != 0)
            {
                break;
            }
        }

        return result.ToArray();
    }
}