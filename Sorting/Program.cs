using System;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int start = 0; start < nums.Length - 1; start++)
            {
                
                int posМin = start;

                for (int next = start + 1; next < nums.Length; next++)

                    if (nums[next] < nums[posМin])
                        posМin = next;

                
                if (posМin != start)
                    Swap(nums, posМin, start);

            }
            Console.WriteLine(string.Join(" ", nums));
        }
        static void Swap(int[] nums, int index1, int index2)
        {

            int oldNum = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = oldNum;
        }
    }
}
