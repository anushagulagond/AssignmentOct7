using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOct7
{
    public class Dictionary
    {
        public int Id;
        public string Name;

        public Dictionary(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void Add(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Console.WriteLine("Student added successfully");
        }

    }
    internal class DictionaryClass
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Arun" );
            dictionary.Add(2, "Anni");
            dictionary.Add(3, "Archana");
 
            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
            Console.WriteLine("Do you want to search any student Name present,please enter ID");
            int IdSearch=int.Parse(Console.ReadLine());
            if (dictionary.ContainsKey(IdSearch))
            {
                Console.WriteLine(dictionary[IdSearch]);
            }
            else
            {
                Console.WriteLine("No Student belongs to this Id");
            }


        }
    }
}
