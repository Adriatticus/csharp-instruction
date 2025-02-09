namespace leet_code_01_two_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two Sum Testing!");

            //example 1
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] indicies = TwoSum(nums, target);

            Console.WriteLine($"Indicies: ");
            foreach (int i in indicies)
            {
                Console.WriteLine($"Indices: {indicies[i]} ");
            }
            


            Console.WriteLine("GL");
        }
        static int[] TwoSum(int[] nums, int target)
        {
            int[] indicies = new int[2];
            // write the method


            return indicies;
        }

    }
}
