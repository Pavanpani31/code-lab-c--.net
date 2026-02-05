using System;

class programe()
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the world to count the Charactor");
        string Input = Console.ReadLine();
        Countcharacter(Input);
        Console.WriteLine("Press any key to exists");
        Console.ReadLine();
    }

    static void Countcharacter(string str)
    {
        Dictionary<char, int> charactorCount = new Dictionary<char, int>();
        foreach (var charactor in str)
        {
            if (charactor != ' ')
            {
                if (!charactorCount.ContainsKey(charactor))
                {
                    charactorCount.Add(charactor, 1);
                }
                else
                {
                    charactorCount[charactor]++;
                }
            }
        }
        foreach (var charactor in charactorCount)
        {
            Console.WriteLine("{0} - {1}", charactor.Key, charactor.Value);
        }
    }
}