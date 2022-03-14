using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static string name;
    static string phrase;
    
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        //people.Add(new Person("Mom")); 
        //int i = 0;
        do
        {
            Console.WriteLine("Enter a name, or enter g to end:");
            name = Console.ReadLine();
            people.Add(new Person(name));
            //Console.WriteLine(people[i].Name);
            //i++;
        } while (name != "g");


        if (people.Count - 1 == 0)
        {
            Console.WriteLine("No one liked your post...");
        }

        else if (people.Count - 1 == 1)
        {
            Console.WriteLine(people[0].Name + " liked your post!");
        }
        else if (people.Count -1 == 2)
        {
            Console.WriteLine(people[0].Name + " and " + (people[1].Name) + " liked your post!");
        }
        else
        {
            Console.WriteLine(people[0].Name + " and " + people[1].Name + " and " + (people.Count - 3) + " others liked your post!");
        } //the -1 is to account for the g to end the do while loop

        
        Dictionary<char, int> dictator = new Dictionary<char, int>();

        Console.WriteLine("Enter a phrase!");
        string phrase = Console.ReadLine();

        Console.WriteLine(phrase);
        char[] ch = phrase.ToCharArray();
        int x = 0;
        foreach(char ch2 in ch)
        {
            if(dictator.ContainsKey(ch2))
            {
                dictator[ch2]++;
            }
            else
            {
                dictator.Add(ch2, 1);
            }
            
            
            x++;
        }
        foreach(KeyValuePair<char, int> kvp in dictator)
        {
            Console.WriteLine(kvp.Key + "|" + kvp.Value);
        }




    }


}
 class Person
{
    List<Person> people = new List<Person>();
    string name;

    public Person(string name)
    {
        this.name = name;
        
    }

    public string Name 
    {
        get { return name; } 
        set { name = value; }
    }

    

}

