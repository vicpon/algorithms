// https://leetcode.com/problems/sort-an-array/

namespace AlgorithmsPractice.LeetCode
{
    public class _912_Sort_Array
    {
        public int[] SortArray(int[] nums)
        {
            var results = MergeSort(nums, new int[0]);
            return results.ToArray();
        }

        List<int> MergeSort(int[] left, int[] right)
        {
            int[] resultL = left, resultR = right;
            if (left.Length > 1)
            {
                // left array
                var pivot = (int)(left.Length/2);
                var left2 = left.Take(pivot).ToArray();
                var right2 = left.Skip(pivot).ToArray();
                // Console.WriteLine("Pivot L {0}", pivot);
                resultL = MergeSort(left2, right2).ToArray();
            }
            if (right.Length > 1)
            {
                // right array
                var pivot = (int)(right.Length/2);
                var left3 = right.Take(pivot).ToArray();
                var right3 = right.Skip(pivot).ToArray();
                // Console.WriteLine("Pivot R {0}", pivot);
                resultR = MergeSort(left3, right3).ToArray();
            }

            return Merge(resultL, resultR);
        }

        List<int> Merge(int[] left, int[] right)
        {
            List<int> results = new List<int>();
            int i = 0, j = 0;
            do
            {
                if (i < left.Length && j < right.Length)
                {
                    if (left[i] < right[j])
                    {
                        results.Add(left[i]);
                        i++;
                    }
                    else
                    {
                        results.Add(right[j]);
                        j++;
                    }
                }
                else if (i < left.Length)
                {
                    results.Add(left[i]);
                    i++;
                }
                else if (j < right.Length)
                {
                    results.Add(right[j]);
                    j++;
                }
            } while (i < left.Length || j < right.Length);
            // Console.WriteLine("Results {0}", String.Join(",", results));
            return results;
        }
    }
}
