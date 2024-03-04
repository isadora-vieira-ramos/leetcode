public class IntegerToRoman {
    public string IntToRoman(int integer) {
        string romanNumeral = null;
        string number = integer.ToString();
        for(int i = number.Length - 1; i >= 0; i--)
        {
            int numeral = Convert.ToInt32(number.Substring(i, number.Length - i));
            if (Convert.ToInt32(number.Substring(i, 1)) == 0)
                continue;
                
            romanNumeral = Calculator(numeral) + romanNumeral;
        }

        return romanNumeral;
    }

     public static string Calculator(int number)
    {
        if (number == 0)
            return null;

        if(number < 10)
        {

            if(number <= 3)
                return new string('I', number);
            
            if(number == 4)
                return "IV";

            if (number == 9)
                return "IX";

            return "V" + new string('I', number - 5);

        }
        else if(number < 100)
        {

            if (number <= 39)
                return new string('X', Convert.ToInt32(number.ToString().Substring(0, 1)));

            if (number >= 40 && number <= 49)
                return "XL";

            if (number >= 50 && number <= 89)
                return "L" + new string('X', Convert.ToInt32(number.ToString().Substring(0, 1)) - 5);

            return "XC";

        }else if(number < 1000)
        {
            if (number <= 399)
                return new string('C', Convert.ToInt32(number.ToString().Substring(0, 1)));

            if(number <= 499)
                return "CD";

            if(number >= 500 && number <= 899)
                return "D" + new string('C', Convert.ToInt32(number.ToString().Substring(0, 1)) - 5);

            return "CM";
        }
        else
        {
            return new string('M', Convert.ToInt32(number.ToString().Substring(0, 1)));
        }
    }
}
