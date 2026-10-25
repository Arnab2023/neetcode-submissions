public class Solution {
    public bool IsPalindrome(string s) {
        bool flag = true;
         int left = 0;
        int right = s.Length-1;
        while(left<right){
       
        while(left<right && !char.IsLetterOrDigit(s[left])) left++; 
        while(left<right && !char.IsLetterOrDigit(s[right])) right--; 
        if(char.ToLower(s[left])!=char.ToLower(s[right])){
                flag = false;
        }
        left++;
        right--;
        
        }
        return flag;
    }
}
