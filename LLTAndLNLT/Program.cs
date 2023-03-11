using System;
public class LLTAndLNLT
{
    public static void Main()
    {
        string[] sports = { "Basketball", "Football", "Volleyball", "CrossCountry", "Softball" };
        LinkedList<string> sportList = new LinkedList<string>(sports);
        Console.WriteLine("------Original sports list--------");
        Console.WriteLine($"Number of sports: {sportList.Count} ");
        foreach (string sport in sportList)
        {
            Console.WriteLine(sport);
        }
        Console.WriteLine();
        sportList.AddFirst("Golf");
        sportList.AddLast("LaCross");

        LinkedListNode <string> targetLocation = sportList.Find("Basketball");
        Console.WriteLine("The current sport after basketball is {0}", targetLocation.Next.Value);
        Console.WriteLine();
        sportList.AddBefore(targetLocation, "Football");
        sportList.AddAfter(targetLocation, "Volleyball");
        Console.WriteLine("-------Revised List--------");
        Console.WriteLine($"Number of sports revised: {sportList.Count}");
        foreach (string sport in sportList)
        {
            Console.WriteLine(sport);
        }
        Console.WriteLine();
        sportList.RemoveFirst();
        sportList.RemoveLast();
        Console.WriteLine("-------List after deletions----------");
        Console.WriteLine($"Here are the remaining: {sportList.Count}");
        foreach (string sport in sportList)
        {
            Console.WriteLine(sport);
        }
        Console.WriteLine() ;

        string[] sportArray = new string[sportList.Count];
        sportList.CopyTo(sportArray, 0);
        Console.WriteLine("--------Friendlist is now friendArray----------");
        Console.WriteLine($"Here are the remaining: {sportList.Count}");
        foreach(string s in sportArray)
        {
            Console.WriteLine(s);
        }
        sportList.Clear();
    }
}
