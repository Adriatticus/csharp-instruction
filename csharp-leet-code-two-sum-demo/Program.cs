using Microsoft.VisualBasic;

namespace csharp_leet_code_two_sum_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1337 learn to 1337!");

            int[] nums = [2, 7, 11, 15];
            //test case 1
            int[] indicies = TwoSum(nums, 9);
            DisplayResults(indicies, "Test Case 1");

            nums = [3, 2, 4];
            //test case 2
            indicies = TwoSum(nums, 6);
            DisplayResults(indicies, "Test Case2");

            nums = [1, 3, 7, 12, 15];
            //test case 3
            indicies = TwoSum(nums, 19);
            DisplayResults(indicies, "Test Case 3");
        }
        static void DisplayResults(int[] indicies, string msg)
        {
            PrintL(msg);
            foreach (int i in indicies)
            {
                Print($"index: {i}, ");
            }
            PrintL("");
        }
        static int[] TwoSum(int[] nums, int target)
        {
            int[] indices = new int[2];
            // my first #
            for (int i = 0; i < nums.Length; i++)
            {
                // my second #
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        Print($"{nums[i]} + {nums[j]}, ");
                        int sum = nums[i] + nums[j];
                        if (sum == target) Print("Target!!!!");
                    }
                    PrintL("");

                }
                // nums - array of ints, once pari of numbers, summed, equals target
                // return indicies of those two numbers


                return indices;
            }
            static void Print(string msg)
            {
                Console.Write(msg);
            }
            static void PrintL(string msg)
            {
                Console.WriteLine(msg);

            }
        }
    }

}
