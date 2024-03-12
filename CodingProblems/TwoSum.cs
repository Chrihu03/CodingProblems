using System;
namespace CodingProblems
{
	public class TwoSum
	{
		public TwoSum()
		{
		}

		static public int[] NestedLoops(int[] nums, int target)
		{
			int[] result = new int[2];
			for (int i = 0; i < nums.Length - 1; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (target == (nums[i] + nums[j]))
					{
						result[0] = i;
						result[1] = j;
						i = j = nums.Length;
					}
				}
			}
			return result;
		}

        static public int[] Dictionary(int[] nums, int target)
        {
            int[] result = new int[2];
			Dictionary<int, int> seenNumbers = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; i++)
			{
				int diff = target - nums[i];
				int foundIndex;
				if (seenNumbers.TryGetValue(diff, out foundIndex))
				{
					result[0] = i;
					result[1] = foundIndex;
					break;
				}
				else
				{
					seenNumbers.TryAdd(nums[i], i);
				}
			}
            return result;
        }
    }
}

