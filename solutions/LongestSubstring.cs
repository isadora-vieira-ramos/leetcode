public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int longestSubstring = 0;

        while(left <= s.Count()-1){
            string lettersFound = "";
            int count = 0;
            int right = left;
            while(right < s.Count() && !lettersFound.Contains(s[right].ToString())){
                count++;
                lettersFound = lettersFound + s[right].ToString();
                right++;
            }
            left++;
            lettersFound = "";
            if(count > longestSubstring){
                longestSubstring = count;
            }
        }
        return longestSubstring;
    }
}
