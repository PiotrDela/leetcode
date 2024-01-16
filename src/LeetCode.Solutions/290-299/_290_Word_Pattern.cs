namespace LeetCode.Solutions;

public class _290_Word_Pattern
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (pattern.Length != words.Length)
        {
            return false;
        }

        var letterToWordMapping = new Dictionary<char, string>();
        var wordToLetterMapping = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++)
        {
            var letter = pattern[i];
            var word = words[i];

            letterToWordMapping.TryAdd(letter, word);
            wordToLetterMapping.TryAdd(word, letter);

            if (letterToWordMapping[letter] != word)
            {
                return false;
            }

            if (wordToLetterMapping[word] != letter)
            {
                return false;
            }
        }

        return true;
    }
}
