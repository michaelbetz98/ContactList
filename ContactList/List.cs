using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    
    public static class List
    {
        public static List<string> names = new List<string>();


        public static void AddContact(string name)
        {
            bool alredyThere = false;
            foreach(string checkname in names)
            {
                if (checkname == name)
                {
                    alredyThere = true;
                }
            }
            if (alredyThere == false)
            {
                names.Add(name);
            }
        }

        public static void PrintList() 
        {
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }
        }

        public static string SearchContact(string name)
        {
            bool alredyThere = false;
            foreach (string checkname in names)
            {
                if (checkname == name)
                {
                    return $"Trovato {name}";
                }
            }
            if (alredyThere == false)
            {
                return $"Non trovato {name}";
            }
            else
            {
                return "";
            }
        }

        public static void RemoveContact(string name)
        {
            bool alredyThere = false;
            foreach (string checkname in names)
            {
                if (checkname == name)
                {
                    names.Remove(name);
                    return;
                }
            }
        }

    }
}
