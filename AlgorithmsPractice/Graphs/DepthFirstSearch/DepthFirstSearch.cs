using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class DepthFirstSearch
{
    public IList<string> LetterCombinations(string digits)
    {
        var map = new Dictionary<int, List<char>>()
            {
                { 2, new List<char> { 'a', 'b', 'c' } },
                { 3, new List<char> { 'd', 'e', 'f' } }
            };

        var letters = new List<string>();
        for (int i = 0; i < digits.Length; i++)
        {
            var digit = int.Parse(digits.Substring(i, 1));
            letters.Add(string.Join("", map[digit]));
        }

        return letters;
    }
}