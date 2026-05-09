public class Solution {
    public int[] GetConcatenation(int[] nums) {
                int[] ans = new int [nums.Length *2];
            int idx=0;
            for(int i =0; i<2; i++)
            {
                foreach (int num in nums)
                {
                    ans[idx++]= num;
                }
            }
            return ans;
    }
}