public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = Int32.MinValue;
        int sum =0 ;
        foreach(int num in nums){
            if(sum <0)
                sum =0;
            sum += num ;
            max = Math.Max(max ,sum);
            }
        return max;
        }
        
    }
