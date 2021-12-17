using System;
using System.Collections.Generic;
using System.IO;

namespace VoteCounter_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader content = File.OpenText(path))
                {
                    Dictionary<string, int> votesData = new Dictionary<string, int>();

                    while (!content.EndOfStream)
                    {
                        string[] data = content.ReadLine().Split(',');
                        string candidate = data[0];
                        int votes = int.Parse(data[1]);

                        if (votesData.ContainsKey(candidate))
                        {
                            votesData[candidate] += votes;
                        }
                        else
                        {
                            votesData.Add(candidate, votes);
                        }
                    }

                    foreach (var data in votesData)
                    {
                        Console.WriteLine($"{data.Key}: {data.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
