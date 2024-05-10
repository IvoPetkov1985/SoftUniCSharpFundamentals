using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            List<User> allUsers = new List<User>();

            string commandLine = Console.ReadLine();

            while (commandLine != "Statistics")
            {
                string[] tokens = commandLine.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "Add")
                {
                    string username = tokens[1];
                    int sentMsg = int.Parse(tokens[2]);
                    int receivedMsg = int.Parse(tokens[3]);

                    User userToAdd = allUsers.FirstOrDefault(x => x.Name == username);

                    if (userToAdd == null)
                    {
                        userToAdd = new User(username, sentMsg, receivedMsg);
                        allUsers.Add(userToAdd);
                    }
                }
                else if (currentCommand == "Message")
                {
                    string senderName = tokens[1];
                    string receiverName = tokens[2];

                    User userToSent = allUsers.FirstOrDefault(x => x.Name == senderName);
                    User userToReceive = allUsers.FirstOrDefault(x => x.Name == receiverName);

                    if (userToSent != null && userToReceive != null)
                    {
                        userToSent.SentMsg++;
                        userToReceive.ReceivedMsg++;
                    }

                    if (userToSent.SentMsg + userToSent.ReceivedMsg >= capacity)
                    {
                        Console.WriteLine($"{senderName} reached the capacity!");
                        allUsers.Remove(userToSent);
                    }

                    if (userToReceive != null && userToReceive.ReceivedMsg + userToReceive.SentMsg >= capacity)
                    {
                        Console.WriteLine($"{receiverName} reached the capacity!");
                        allUsers.Remove(userToReceive);
                    }
                }
                else if (currentCommand == "Empty")
                {
                    string name = tokens[1];

                    if (name != "All")
                    {
                        User userToDelete = allUsers.FirstOrDefault(x => x.Name == tokens[1]);

                        if (userToDelete != null)
                        {
                            allUsers.Remove(userToDelete);
                        }
                    }
                    else
                    {
                        allUsers.Clear();
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {allUsers.Count}");

            if (allUsers.Count > 0)
            {
                foreach (User user in allUsers)
                {
                    Console.WriteLine($"{user.Name} - {user.SentMsg + user.ReceivedMsg}");
                }
            }
        }
    }

    public class User
    {
        public User(string name, int sent, int received)
        {
            this.Name = name;
            this.SentMsg = sent;
            this.ReceivedMsg = received;
        }
        public string Name { get; set; }
        public int SentMsg { get; set; }
        public int ReceivedMsg { get; set; }
    }
}
