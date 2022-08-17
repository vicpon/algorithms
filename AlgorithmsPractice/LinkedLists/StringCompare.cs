// https://www.geeksforgeeks.org/compare-two-strings-represented-as-linked-lists/

public class StringCompare
{
    public StringCompare(string input1, string input2)
    {
        var result = Compare(new LinkedList<char>(input1.ToArray()), new LinkedList<char>(input2.ToArray()));
        Console.WriteLine("StringCompare: {0}", result);
    }

    public static int Compare(LinkedList<char> string1, LinkedList<char> string2)
    {
        var pointer1 = string1.First;
        var pointer2 = string2.First;

        while (pointer1 != null && pointer2 != null)
        {
            if (pointer1.Value < pointer2.Value) return -1;
            if (pointer1.Value > pointer2.Value) return 1;

            pointer1 = pointer1.Next;
            pointer2 = pointer2.Next;
        }
        return 0;
    }
}