using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LCS - Longest Common Subsequence - https://www.geeksforgeeks.org/longest-common-subsequence-dp-4/
internal class LongestCommonSubequence
{
    List<string> sequences = new List<string>();

    public LongestCommonSubequence(string input1, string input2)
    {
        for (var i = 0; i < input1.Length; i++)
        {
            var sequence = "";
            CheckSequence(ref sequence, input1.Substring(i), input2);
            sequences.Add(sequence);
        }
        Console.WriteLine(sequences.OrderBy(x => x.Length).Last());
    }

    void CheckSequence(ref string sequence, string input1, string input2)
    {
        for (var i = 0; i < input1.Length; i++)
        {
            for (var j = 0; j < input2.Length; j++)
            {
                if (input1[i] == input2[j])
                {
                    sequence += input2[j];
                    CheckSequence(ref sequence, input1.Substring(i+1), input2.Substring(j+1));
                    return;
                }
            }
        }
    }
}
