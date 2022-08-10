using System.Collections;
using System.Collections.Generic;
namespace InecSol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void InecVoters()
            {
                //declaring an empty dictionary of data type string and int which will contain the name and the number of times they occur in the list
                SortedDictionary<string,int> nameDict =new SortedDictionary<string,int>();

                //A list of voters probably extracted from the database
                var voterNames = new List<string> {
                    "Mark Tyson",
                    "John Feranmi",
                    "Lucy Lawal",
                    "Jane Suleja",
                    "Abby Jensen",
                    "Sola Allison",
                    "Roseline Afije",
                    "Lily Oriflame",
                    "Messi Santino",
                    "Carl Rodriguez",
                    "Lucy Lawal",
                    "Jane Suleja",
                    "Harry Suleja",
                    "John Feranmi",
                    "Lily Oriflame",
                    "Louis Tomlinson",
                    "Cassie Tomlinson",
                    "John Feranmi",
                    "Sola Allison",
                    "Jerry Lawler",
                    "Dwayne Johnson",
                    "Lucy Lawal"
                };

                //converting the list to a hashset since hashset does not take duplicate values
                HashSet<string> sortedNameHashed= voterNames.ToHashSet();

                //counting the occurence of each names in the list and adding it to a dictionary
                foreach (string name in sortedNameHashed)
                {
                    int occurence=voterNames.Count(x=>x==name);
                    nameDict.Add(name, occurence);
                }

                //looping through the dictionary and printing out the names that occur more than once
                Console.WriteLine("Below are the voters that registered multiple times");
                foreach( var item in nameDict)
                {
                    if (item.Value <= 1)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{item.Key} registered {item.Value} times");
                    }
                }
                Console.WriteLine("Enter the name of the new voter");
                string newVoter = Console.ReadLine();
                if (nameDict.ContainsKey(newVoter))
                {
                    Console.WriteLine("This voter exists");
                }
                else
                {
                    voterNames.Add(newVoter);
                }

            }

            InecVoters();        
        }
    }
}