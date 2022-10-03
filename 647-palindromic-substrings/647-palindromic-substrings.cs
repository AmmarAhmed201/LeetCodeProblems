public class Solution {
    public int CountSubstrings(string s) {
        int result =0 ;
        for(int i =0 ;i<s.Length ;++i){
            for(int j=i ;j<s.Length;++j){
                if(isPalindromic(s,i,j)){
                    result++;
                }
            }
        }
        return result;
    }
    private bool isPalindromic(string s, int start, int end){
        while (start<end){
            if(s[start]!=s[end]){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}