public class FizzBuzz {
    public IList<string> DivisibleBy3Or5(int n) {
        List<string> answer = new List<string>();
        for(int i = 1; i <= n; i++){
            bool divisibleByFive = i%5 == 0;
            bool divisibleByThree = i%3 == 0;
            if(divisibleByFive && divisibleByThree)
                answer.Add("FizzBuzz");
            else if(divisibleByFive && !divisibleByThree)
                answer.Add("Buzz");
            else if(!divisibleByFive && divisibleByThree)
                answer.Add("Fizz");
            else
                answer.Add($"{i}");
        }
        return answer;
    }
}
