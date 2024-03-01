public class RunningSumArray {
    public int[] RunningSum(int[] nums) {
        int[] sum = new int[nums.Length];
        int sumTotal = 0;
        for(int i = 0; i < nums.Length; i++){
            sumTotal += nums[i];
            sum[i] = sumTotal;
        }
        return sum;
    }
}
