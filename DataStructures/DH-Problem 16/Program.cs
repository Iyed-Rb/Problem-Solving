namespace DH_Problem_16
{
    internal class Program
    {

        static List<char> FindCommonCharacters(List<string> list)
        {
            List<char> result = new List<char>();
            int count = list.Count;

            // Step 1: Precompute character counts for each string
            List<Dictionary<char, int>> stringCounts = new List<Dictionary<char, int>>();
            foreach (string str in list)
            {
                Dictionary<char, int> charCount = new Dictionary<char, int>();
                foreach (char c in str)
                {
                    if (!charCount.ContainsKey(c))
                        charCount[c] = 1;
                    else
                        charCount[c]++;
                }
                stringCounts.Add(charCount);
            }

            // Step 2: Loop over characters of the first string
            foreach (var kvp in stringCounts[0])
            {
                char c = kvp.Key;
                int minFreq = kvp.Value;
                bool isFound = true;

                for (int i = 1; i < count; i++)
                {
                    if (stringCounts[i].ContainsKey(c))
                    {
                        if (stringCounts[i][c] < minFreq)
                            minFreq = stringCounts[i][c];
                    }
                    else
                    {
                        isFound = false;
                        break;
                    }
                }

                if (isFound)
                {
                    for (int j = 0; j < minFreq; j++)
                        result.Add(c);
                }
            }

            return result;
        }

        static List<string> CommonChars(string[] words)
        {
            int[] minFreq = new int[26];
            Array.Fill(minFreq, int.MaxValue);


            foreach (string word in words)
            {
                int[] charFreq = new int[26];
                foreach (char c in word)
                {
                    charFreq[c - 'a']++;
                }


                for (int i = 0; i < 26; i++)
                {
                    minFreq[i] = Math.Min(minFreq[i], charFreq[i]);
                }
            }

            List<string> result = new List<string>();
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < minFreq[i]; j++)
                {
                    result.Add(((char)(i + 'a')).ToString());
                }
            }

            return result;
        }



        static void Main(string[] args)
        {
            List<string> list = new List<string> { "bella", "label", "roller" };
            List<char> chars = FindCommonCharacters(list);
            Console.WriteLine("Common Characters: " + string.Join(", ", chars));
        }
    }
}

