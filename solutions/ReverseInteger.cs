public class ReverseInteger {
    public int Reverse(int x) {
        string number = x.ToString();
        string reversedNumber = "";

        if (x < 0)
        {
            reversedNumber = "-";
            number = number.Substring(1);
        }

        if (number.Substring(number.Length - 1, 1).Equals("0") && number.Length > 1)
            number = number.Substring(0, number.Length - 1);

        char[] stringArray = number.ToCharArray();
        Array.Reverse(stringArray);
        reversedNumber += new string(stringArray);
        
        return Convert.ToInt64(reversedNumber) > Int32.MaxValue || Convert.ToInt64(reversedNumber) < Int32.MinValue ? 0 : Convert.ToInt32(reversedNumber);
    }
}
