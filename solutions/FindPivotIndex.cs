public class FindPivotIndex {

    public int PivotIndex(int[] nums)
        {
            int pivot = -1;
            for(int i = 0; i < nums.Length; i++){
                int left = CalculateLeft(i, nums);
                int right = CalculateRight(i, nums);
                if (left == right)
                {
                    if (left == 0)
                        if (i == 0)
                            pivot = 0;
                        else
                            pivot = i;
                    else
                        pivot = i;
                    break;
                }
            }
            return pivot;
        }

        public int CalculateLeft(int position, int[] nums)
        {
            int sum = 0;
            if (position == 0)
                return 0;

            for (int j = 0; j < position; j++)
            {
                sum += nums[j];
            }
            return sum;
        }

        public int CalculateRight(int position, int[] nums)
        {
            if (position == nums.Length - 1)
                return 0;
            int sum = 0;
            for (int j = position + 1; j < nums.Length; j++)
            {
                sum += nums[j];
            }
            return sum;
        }

}
