public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        Recer(new HashSet<int>(nums) , new List<int>(), result);
        return result;
        
    }
    public void Recer(HashSet<int> nums , List<int> prefix,IList<IList<int>> result){
        
        if(nums.Count == 0){
            result.Add(new List<int>(prefix));
            return ;
        }
        HashSet<int> remaining = new HashSet<int>(nums);
        foreach(var num in nums){
            prefix.Add(num);
            remaining.Remove(num);
            Recer(remaining,prefix,result);
            remaining.Add(num);
            prefix.RemoveAt(prefix.Count -1);
        }
    }
}