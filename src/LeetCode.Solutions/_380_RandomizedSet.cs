//Implement the RandomizedSet class:

//    RandomizedSet() Initializes the RandomizedSet object.
//    bool insert(int val) Inserts an item val into the set if not present.Returns true if the item was not present, false otherwise.
//    bool remove(int val) Removes an item val from the set if present.Returns true if the item was present, false otherwise.
//    int getRandom() Returns a random element from the current set of elements (it's guaranteed that at least one element exists when this method is called). Each element must have the same probability of being returned.

//You must implement the functions of the class such that each function works in average O(1) time complexity.

namespace LeetCode.Solutions._380_389
{
    internal class _380_RandomizedSet
    {
        private Dictionary<int, int> valueToIndex = new Dictionary<int, int>();
        private Dictionary<int, int> indexToValue = new Dictionary<int, int>();

        private int count = 0;

        private Random random = new Random((int)DateTime.UtcNow.Ticks);

        public bool Insert(int val)
        {
            if (valueToIndex.TryAdd(val, count))
            {
                indexToValue.Add(count, val);
                count++;
                return true;
            }

            return false;
        }

        public bool Remove(int val)
        {
            if (valueToIndex.TryGetValue(val, out int index))
            {
                if (index == count - 1) // if last element
                {
                    valueToIndex.Remove(val);
                    indexToValue.Remove(index);
                }
                else
                {
                    var lastElementIndex = count - 1;
                    var lastElementValue = indexToValue[lastElementIndex];

                    indexToValue[index] = lastElementValue;
                    valueToIndex[lastElementValue] = index;

                    valueToIndex.Remove(val);
                    indexToValue.Remove(lastElementIndex);
                }

                count--;
                return true;
            }

            return false;
        }

        public int GetRandom()
        {
            var t = random.Next(count);
            return indexToValue[t];
        }
    }
}
