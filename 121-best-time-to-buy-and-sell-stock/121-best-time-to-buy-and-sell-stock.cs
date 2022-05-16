public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxDifference = 0;
        int n = prices.Count();
        for (int i =0;i<n;i++){
            if (prices[i] < minPrice ){
                    minPrice = prices[i];
            }
            else if(prices[i]-minPrice > maxDifference)
                maxDifference = prices[i]-minPrice;
            
        }
        return maxDifference;
    }
}