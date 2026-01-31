namespace DH_Problem_19
{
    internal class Program
    {
        static bool NonCommonElement(List<int> list1, List<int> list2)
        {
            HashSet<int> set = new HashSet<int>(list1);

            foreach (int item in list2)
            {
                if (set.Contains(item))
                    return false;
            }

            return true;
        }

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

            set1.IntersectWith(set2);

            return set1.ToArray();
        }


        static void Main(string[] args)
        {
            List<int> list1 = new List<int> {1, 2, 3 };
            List<int> list2 = new List<int> {4, 5, 6 };
            Console.WriteLine("Hello, World!");
        }
    }
}
