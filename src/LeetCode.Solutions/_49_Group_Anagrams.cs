//Given an array of strings strs, group the anagrams together. You can return the answer in any order.

//An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

namespace LeetCode.Solutions._40_49
{
    public class _49_Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var groups = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                var sortedString = SortString(str);
                if (groups.TryGetValue(sortedString, out var list))
                {
                    list.Add(str);
                }
                else
                {
                    groups.Add(sortedString, new List<string>() { str });
                }
            }

            return groups.Values.ToList();
        }

        private static string SortString(string str)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
    }
}
