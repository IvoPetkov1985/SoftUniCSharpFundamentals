using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messages_Manager_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            Dictionary<string, Info> allUsers = new Dictionary<string, Info>();

            string commandLine = Console.ReadLine();

            while (commandLine != "Statistics")
            {
                string[] tokens = commandLine.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Add")
                {
                    string username = tokens[1];
                    int sent = int.Parse(tokens[2]);
                    int received = int.Parse(tokens[3]);

                    if (!allUsers.ContainsKey(username))
                    {
                        allUsers.Add(username, new Info());
                        allUsers[username].sendMsgs = sent;
                        allUsers[username].receivedMsgs = received;
                    }
                }
                else if (command == "Message")
                {
                    string sender = tokens[1];
                    string receiver = tokens[2];

                    if (allUsers.ContainsKey(sender) && allUsers.ContainsKey(receiver))
                    {
                        allUsers[sender].sendMsgs++;
                        allUsers[receiver].receivedMsgs++;

                        if (allUsers[sender].sendMsgs + allUsers[sender].receivedMsgs >= maxCapacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            allUsers.Remove(sender);
                        }

                        if (allUsers[receiver].sendMsgs + allUsers[receiver].receivedMsgs >= maxCapacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            allUsers.Remove(receiver);
                        }
                    }
                }
                else if (command == "Empty")
                {
                    string username = tokens[1];

                    if (username == "All")
                    {
                        allUsers.Clear();
                    }
                    else
                    {
                        allUsers.Remove(username);
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {allUsers.Count}");

            foreach (KeyValuePair<string, Info> kvp in allUsers)
            {
                int totalMsgs = kvp.Value.sendMsgs + kvp.Value.receivedMsgs;

                Console.WriteLine($"{kvp.Key} - {totalMsgs}");
            }
        }
    }

    public class Info
    {
        public int sendMsgs { get; set; }
        public int receivedMsgs { get; set; }
    }
}
