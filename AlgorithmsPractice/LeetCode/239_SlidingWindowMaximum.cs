// https://leetcode.com/problems/sliding-window-maximum/
namespace AlgorithmsPractice.LeetCode
{
    public class SlidingWindowMaximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            List<int> results = new List<int>();
            var (currentMax, currentMaxIndex) = FindMax(nums, 0, k);
            results.Add(currentMax);
            for (int i = 1; i < nums.Length - k + 1; i++)
            {
                // Console.WriteLine("Current max {0}, index {1}, i {2}", currentMax, currentMaxIndex, i);
                if (currentMaxIndex <= 0)
                {
                    var (max, maxIndex) = FindMax(nums, i, k);
                    // Console.WriteLine("New max {0}, index {1}", max, maxIndex);
                    currentMax = max;
                    currentMaxIndex = maxIndex;
                }
                else if (nums[i + k - 1] > currentMax)
                {
                    currentMax = nums[i + k - 1];
                    currentMaxIndex = k - 1;
                }
                results.Add(currentMax);
                currentMaxIndex--;
            }
            return results.ToArray();
        }

        (int, int) FindMax(int[] nums, int start, int len)
        {
            // Console.WriteLine("Looking at indexes {0} - {1}", start, start+len-1);
            int max = Int32.MinValue;
            int maxIndex = -1;
            for (int i = start; i < start + len; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i - start;
                }
            }
            return (max, maxIndex);
        }
    }
}