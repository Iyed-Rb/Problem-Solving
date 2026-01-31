namespace DH_Problem_18_
{
    internal class Program
    {
        static List<int> FindAllNumbersMissing(List<int> nums)
        {
            HashSet<int> Numbers = new HashSet<int>(nums);
            List<int> MissingNumbers = new List<int>();

            int count = Numbers.Count;

            for (int i = 1; i <= count; i++)
            {
                if (!Numbers.Contains(i))
                {
                    MissingNumbers.Add(i);
                }
            }

            return MissingNumbers;
        }

        public class Solution
        {
            public IList<int> FindDisappearedNumbers(int[] nums)
            {
                HashSet<int> numbers = new HashSet<int>(nums);
                List<int> missingNumbers = new List<int>();

                for (int i = 1; i <= nums.Length; i++)
                {
                    if (!numbers.Contains(i))
                    {
                        missingNumbers.Add(i);
                    }
                }

                return missingNumbers;
            }
        }


        static void Main(string[] args)
        {
            List<int> list = new List<int> {4, 3, 2 , 7, 8 , 2, 3, 1 };

            Console.WriteLine("Missing Numbers: " + string.Join(", ", FindAllNumbersMissing(list)));
        }
    }
}
