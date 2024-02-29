public class PalindromeNumber {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;

        char[] numberToString = x.ToString().ToArray();
        int lastPosition = numberToString.Length - 1;

        for(int i = 0; i < lastPosition; i++){
            if(numberToString[i] != numberToString[lastPosition])
                return false;
            
            lastPosition--;
        }

        return true;
    }
}
