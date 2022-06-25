public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
     int[] resultArr = new int[2];
            int l = 0;
            int r = numbers.Length-1;
            while (l<r)
            {
                if (numbers[l] + numbers[r]== target)              
                {
                    resultArr = new int[] { l + 1, r + 1 };
                    break;
                }
                else if (numbers[l] + numbers[r]> target  )
                {
                    r--; 

                }
                else if (numbers[l] + numbers[r] < target)
                {
                    l++;
                } 
            }
            return resultArr;  
    }
}