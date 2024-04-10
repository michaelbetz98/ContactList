namespace ContactList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.Clear();
                List.PrintList();
                string line = Console.ReadLine();
                string[] command = line.Split(' ');
                switch (command[0])
                {
                    case "add":
                        List.AddContact(command[1]);
                        break;
                    case "search":
                        List.SearchContact(command[1]);
                        break;
                    case "remove":
                        List.RemoveContact(command[1]);
                        break;
                    default:
                        break;
                }

            }
            while (true);
            
        }
    }
}
